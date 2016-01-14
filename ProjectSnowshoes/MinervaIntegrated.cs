using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;
using System.Collections;
using SpeechLib;
using System.Reflection;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;


namespace ProjectSnowshoes
{
    public partial class MinervaIntegrated : Form
    {

        Dictionary<string, string> responses = new Dictionary<string, string>(); //the dictionary of everything
        Dictionary<DateTime, string> reminders = new Dictionary<DateTime, string>(); //the dictionary of reminders

        //songs
        String mediaLib; //where the user's media library is
        string[] songs; //stores songs after finding them in the media library
        ArrayList songsT = new ArrayList(); //temporarily holds songs

        String inputText = ""; //inputted text
        String respondingTo = ""; //if the user says something Minerva doesn't recognize, this is it
        //this will be used as the key in the dictionary, and the next input will be the value
        Boolean noteResponse = false; //specifies if the next input is a response to the statement resondingTo

        Boolean noteReminderTime = false;
        String reminderObj = "";
        String dataTemp = "";

        String urlToGoTo = "";

        int CharlarCounter = 0;
        private SpSharedRecoContext withEventsField_RecoContext;
        public SpSharedRecoContext RecoContext
        {
            get { return withEventsField_RecoContext; }
            set
            {
                if (withEventsField_RecoContext != null)
                {
                    withEventsField_RecoContext.Recognition -= OnReco;
                }
                withEventsField_RecoContext = value;
                if (withEventsField_RecoContext != null)
                {
                    withEventsField_RecoContext.Recognition += OnReco;
                }
            }
        }
        ISpeechRecoGrammar grammar;
        int CharCount;

        SpVoice speech = new SpVoice();
        // Boolean rememberThis = false;       // Given validity (made true) upon entering a response to the "Could you remember" section.


        public MinervaIntegrated()
        {
            //default stuff
            InitializeComponent();
            //speech.Voice = speech.GetVoices("gender=female").Item(1);
            //load in the dictionary

            //here, Minerva tries to load in data and prefs
            //if an error is thrown, it means the file does not exist
            //thus Minerva makes one
            try
            {
                System.IO.File.ReadAllLines(@"data.txt");
            }
            catch
            {
                System.IO.File.WriteAllText(@"data.txt", "");
            }
            try
            {
                System.IO.File.ReadAllLines(@"prefs.txt");
            }
            catch
            {
                System.IO.File.WriteAllText(@"prefs.txt", "");
            }

            string[] dictIn = System.IO.File.ReadAllLines(@"data.txt");
            string[] prefs = System.IO.File.ReadAllLines(@"C:\ProjectSnowshoes\System\App\prefs.txt");
            if (dictIn != null)
            {
                loadDict(dictIn);
                // rTextBox1.AppendText("Dictionary loaded." + "\r\n");
            }
            if (prefs == null || prefs.Length < 1)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Choose your media folder";
                fbd.ShowDialog();
                mediaLib = fbd.SelectedPath;
                String[] temp = new String[1];
                temp[0] = mediaLib;
                System.IO.File.WriteAllLines(@"prefs.txt", temp);
                findSongs();
            }
            else
            {
                mediaLib = prefs[0];
                findSongs();
            }
            // startSpeech(); We are not doing speech just yet for Minerva in general, and will likely work with Webkit Speech Synthesis and Recognition instead.
        }

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //if you press the enter button on the gui, call submit
            submit("");
        }

        private void query_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //or if you press your enter key on your keyboard, call submit
                submit("");
            }
        }

        private void startSpeech()
        {
            if (RecoContext == null)
            {
                RecoContext = new SpSharedRecoContext();
                grammar = RecoContext.CreateGrammar(1);
                grammar.DictationLoad();
            }

            grammar.DictationSetState(SpeechRuleState.SGDSActive);    // Opens up diction possibility.
        }

        private void OnReco(int StreamNumber, object StreamPosition, SpeechRecognitionType RecognitionType, ISpeechRecoResult Result)
        {
            string recoResult = Result.PhraseInfo.GetText();    // Translates whatever was somewhat definitively recognized by Windows Speech Recognition into text.

            recoResult = recoResult.ToLower();          // This is the same as taking inquiry text and making it all lowercase in Minerva.

            submit(recoResult);
        }

        private void loadDict(String[] input)
        {
            Boolean key = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (key && i + 1 < input.Length)
                {
                    responses.Add(input[i], input[i + 1]);
                    key = false;
                }
                else
                {
                    key = true;
                }
            }
        }

        private String[] dictToText()
        {
            String temp = "";
            foreach (var pair in responses)
            {
                temp = temp + pair.Key + ";" + pair.Value + ";";
            }
            return temp.Split(';');
        }

        private void findSongs() //this finds songs from the media library location
        {
            findSongsIn(mediaLib);
            songs = (string[])songsT.ToArray(typeof(string));
        }

        private void findSongsIn(String lib) //finds songs in a specific library
        {
            String[] dir = System.IO.Directory.GetDirectories(@lib);
            foreach (String d in dir)
            {
                findSongsIn(d);
            }
            String[] temp = System.IO.Directory.GetFiles(@lib, "*mp3");
            foreach (String i in temp)
            {
                songsT.Add(i);
            }
            String[] temp1 = System.IO.Directory.GetFiles(@lib, "*flac");
            foreach (String i in temp1)
            {
                songsT.Add(i);
            }
            String[] temp2 = System.IO.Directory.GetFiles(@lib, "*wav");
            foreach (String i in temp2)
            {
                songsT.Add(i);
            }
            String[] temp3 = System.IO.Directory.GetFiles(@lib, "*alac");
            foreach (String i in temp3)
            {
                songsT.Add(i);
            }
        }

        private String getSong(String name) //returns the file location of a song with a given name
        {
            name = name.ToLower();
            string returnS = null;
            for (int i = 0; i < songs.Length; i++)
            {
                if (songs[i].ToLower().Replace('_', ' ').Contains(name))
                {
                    returnS = songs[i];
                }
            }
            return returnS;
        }

        private String songsList()
        {
            String list = "";
            for (int i = 0; i < songs.Length; i++)
            {
                list = list + songs[i] + "\r\n";
            }
            return list;
        }

        private String getWebpage(String URL)
        {
            String URI = URL; //example: http://www.google.com
            String request = "";

            try //this happens, and if there is an error, the catch is called
            {
                WebClient webClient = new WebClient();
                Stream stream = webClient.OpenRead(URI);
                StreamReader streamreader = new StreamReader(stream);
                request = streamreader.ReadToEnd();
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                {
                    switch (((HttpWebResponse)ex.Response).StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                            break;

                        default:
                            throw ex;
                    }
                }
            } //end catch

            return request;
        }

        private String parseWikipedia(String source)
        {
            String output = source;
            int start = source.IndexOf("<p>") + "<p>".Length;
            int end = source.IndexOf("</p>");
            int length = end - start;
            output = "start " + start + " end " + end + " length " + length;
            output = source.Substring(start, end - start);
            output = StripTagsCharArray(output);
            return output;
        }

        private String parseThatYoungWeatherYo(String source)
        {
            String output = source;
            int start = source.IndexOf("temperature-fahrenheit") + "temperature-fahrenheit".Length;
            int end = source.IndexOf("");
            return output;
        }

        public static string StripTagsCharArray(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }

        private void parseCommand(String cmdIn)
        {
            //this parses console commands, and does stuff
            cmdIn = cmdIn.ToLower();
            cmdIn = cmdIn.TrimEnd('.');
            cmdIn = cmdIn.TrimEnd('?');
            cmdIn = cmdIn.TrimEnd('!');



            if (cmdIn.Equals("\\help"))
            {
                /*rTextBox1.AppendText("\\help - acess help" + "\r\n" +
                    "\\clear - clear chat" + "\r\n" +
                    "\\erasedata - erase dictionary data" + "\r\n" +
                    "\\save - save dictionary data" + "\r\n");*/
            }
            else if (cmdIn.Equals("\\clear"))
            {
                //rTextBox1.Text = "";
            }
            else if (cmdIn.Equals("\\yoga2"))
            {
                /*Properties.Settings.Default.youAreLivingThatYoga2Life = true;
                Properties.Settings.Default.Save();*/
            }
            else if (cmdIn.Equals("\\jumprj"))
            {
                //rTextBox1.AppendText("Opening now. \n");
                //Main2 newmain = new Main2();
                //newmain.Show();
                //newmain.BringToFront();
            }
            else if (cmdIn.Equals("\\erasedata"))
            {
                responses = new Dictionary<string, string>();
            }
            else if (cmdIn.Equals("\\save"))
            {
                string[] lines = dictToText();
                System.IO.File.WriteAllLines(@"data.txt", lines);
            }
            else
            {
                //rTextBox1.AppendText("Command not recognized, type \"\\help\" for help");
            }
        }

        private void minervaSay(String input) //have minerva say the input string
        {
            /* Label integration, to where a label is drawn on the spot by minervaSay. This is useful later with more interactive controls to spawn.
             * 
             * Label minervaLabel = new Label();
            minervaLabel.Visible = true;
            minervaLabel.Location = new System.Drawing.Point(2, 2);
            minervaLabel.Font = new System.Drawing.Font("Wasco Sans", 14);
            minervaLabel.ForeColor = Color.White;
            minervaLabel.Text = input;
            this.Controls.Add(minervaLabel);
             * 
             */

            // This is the first label to use, and is pretty much all we are concerned with for now.

            minervaResponse.Text = input;

            //rTextBox1.AppendText("Minerva: " + input + "\r\n");
            Application.DoEvents();
            //speech.Speak(input);
            Application.DoEvents();
        }

        private void submit(String input)
        {
            /* This is where all the magic happens. After the user presses enter or the enter key,
             this method is called. Starter functionality: ask for a response to statement's Minerva
             doesn't have a response to. Then there are certain functions that need to be coded in.
             These are:
             
             Math: "what is _ equal to?"
             Dictionary: "what does _ mean?" || "what's the definition of _?"W
             Wikipedia: Use http://en.m.wikipedia.org/w/index.php?search= + search term
             */

            if (input == "")
                inputText = query.Text;
            else

                /* This should remove any objects not pre-spawned on the page, yet make sure this works before re-adding it here.
                 * 
                for (int i = this.Controls.Count - 1; i >= 0; i += -1)
                {
                    if (this.Controls[i].Name != "button2" & this.Controls[i].Name != "rTextBox1" & this.Controls[i].Name != "query")
                    {
                        this.Controls.RemoveAt(i);
                    }
                }
                 * 
                 */

                inputText = input;

            //rTextBox1.AppendText("You: " + inputText + "\r\n");
            query.Text = "";
            if (inputText.StartsWith("\\"))
            {
                //it's a console command!
                parseCommand(inputText);
            }
            else
            {
                if (noteResponse)
                {
                    responses.Add(respondingTo, inputText);
                    minervaSay("Got it. I'll remember that.");
                    noteResponse = false;
                }
                else if (noteReminderTime)
                {
                    try
                    {
                        reminders.Add(DateTime.Parse(inputText), reminderObj);
                        minervaSay("Alright, I'll remind you when that happens.");
                    }
                    catch
                    {
                        minervaSay("Seriously, what are you even saying? (Don't answer that, it's rhetorical.)");
                    }

                    noteReminderTime = false;
                }
                else
                {
                    mmmWhatchaSay.Text = inputText;
                    inputText = inputText.ToLower();
                    inputText = inputText.Replace(".", "");
                    inputText = inputText.Replace("?", "");
                    inputText = inputText.Replace("!", "");
                    DateTime dt = DateTime.Now;
                    /* Start with the pre-programmed stuff, like math and web searching */
                    if (inputText.Equals("what time is it"))
                    {
                        minervaSay("Time to get a watch. It is now " + dt.ToString("t") + ".");
                    }
                    else if (inputText.Equals("what day is it"))
                    {
                        minervaSay("It's on the taskbar...today is " + dt.DayOfWeek + ", " + dt.ToString("MMMM dd, yyyy") + ".");
                    }
                    else if (inputText.StartsWith("play ")) //ex: play stairway to heaven
                    {
                        String temp = getSong(inputText.Substring(5));
                        if (temp != null)
                        {
                            mediaPlayer.URL = temp;
                            minervaSay("Here's " + mediaPlayer.currentMedia.getItemInfo("title") + " by " + mediaPlayer.currentMedia.getItemInfo("artist") + ".");
                        }
                        else
                        {
                            minervaSay("You're not giving me anything to work with here. Where's the song? I definitely don't have it.");
                        }

                    }
                    else if (inputText.Equals("play"))
                    {
                        mediaPlayer.Ctlcontrols.play();
                    }
                    else if (inputText.Equals("stop") || inputText.Equals("pause"))
                    {
                        mediaPlayer.Ctlcontrols.pause();
                    }
                    else if (inputText.Equals("list songs"))
                    {
                        minervaSay(songsList());
                    }
                    else if (inputText.Equals("who made you") || inputText.Equals("who made you?"))
                    {
                        minervaSay("I was made by a few silly geese over at IndigoBox Studios. If you want, you can read more at their website (in other words, hope you have some good luck, it might not even be up).");
                        linkToSomewhereYouSillyJoven.Show();
                        linkToSomewhereYouSillyJoven.Text = "Visit IndigoBox Website";
                        urlToGoTo = "http://indigoboxstudios.tk/";

                    }
                    else if (inputText.StartsWith("could you remember"))
                    {
                        minervaSay("Nope. \n \n \n \n Yes, of course. What do you want?");
                        //rememberThis = true;
                        noteResponse = true;
                        respondingTo = inputText;
                    }
                    else if (inputText.Contains("hello") || inputText.Contains("hey there") || inputText.Contains("hi"))
                    {
                        minervaSay("Hello, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "!");
                    }
                    else if (inputText.StartsWith("i want") && !inputText.Contains("i want you to wow me"))
                    {
                        minervaSay("And I want a .NET form made out of solid gold, yet here we are.");
                    }
                    else if (inputText.StartsWith("call me"))
                    {
                        String ohNaNa = inputText.Remove(0, 8);
                        String justTheFirstLetter = ohNaNa.Remove(1);
                        justTheFirstLetter = justTheFirstLetter.ToUpper();
                        String andNowForTheRest = ohNaNa.Remove(0, 1);
                        String allTogetherNow = justTheFirstLetter + andNowForTheRest;
                        minervaSay("Alright, " + allTogetherNow + ", I'll start calling you by that name instead.");
                        Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] = allTogetherNow;
                        Properties.Settings.Default.Save();
                    }
                    else if (inputText.StartsWith("can you remind me"))
                    {
                        reminderObj = inputText.Substring(17);
                        minervaSay("Sure. What date and time would it be on?");
                        noteReminderTime = true;
                    }
                    else if (inputText.Equals("price of bitcoin") || inputText.Equals("what is the price of bitcoin") || inputText.Equals("what is the price of bitcoin?") || inputText.Equals("what's the price of bitcoin") || inputText.Equals("what's the price of bitcoin?"))
                    {

                        minervaSay("Right now, the buying price on it is " + parseBitcoin(getWebpage("https://coinbase.com/charts")) + ". Knowing the trends of Bitcoin, though, I personally suggest trying out Dogecoin as well.");
                        linkToSomewhereYouSillyJoven.Show();
                        linkToSomewhereYouSillyJoven.Text = "Visit Dogecoin's Website";
                        urlToGoTo = "http://dogecoin.com";

                    }
                    
                    else if (inputText.StartsWith("is there a reminder on"))
                    {
                        DateTime temp = DateTime.Parse(inputText.Substring(22));
                        if (reminders[temp] != null)
                        {
                            minervaSay("I checked, and there's \"" + reminders[temp] + "\"");
                        }
                        else
                        {
                            minervaSay("Nope, there's nothing.");
                        }
                    }
                    else if (inputText.StartsWith("i want you to wow me.") || inputText.StartsWith("i want you to wow me"))
                    {
                        this.BackgroundImage = Properties.Resources.wow;
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                        minervaResponse.ForeColor = Color.Plum;
                        minervaResponse.BackColor = Color.Transparent;
                        //itsMinervaWoah.BackColor = Color.Transparent;
                        minervaSay("Wow. Such change. Very adjust. Wow.");
                        minervaResponse.Font = new System.Drawing.Font("Comic Sans MS", 12);
                    }
                    else if (inputText.Equals("do i have anything today?"))
                    {
                        DateTime today = DateTime.Now.Date;
                        if (reminders.ContainsKey(today))
                        {
                            minervaSay("I'm sorry, it wasn't my day to watch out for you. \n \nWhoops, I guess it was. There's \"" + reminders[today] + "\"");
                        }
                        else
                        {
                            minervaSay("There's nothing for you to do today.\n\n...Days like these come around very rarely...embrace them.");
                        }
                    }
                    else if (inputText.StartsWith("what is"))
                    {
                        if (responses.ContainsKey(inputText.Remove(0, 8)))
                        {
                            minervaSay(responses[inputText]);
                        }
                        else
                        {
                            minervaSay("According to Wikipedia, " + parseWikipedia(getWebpage("http://en.m.wikipedia.org/w/index.php?search=" + inputText.Substring(7))));
                        }
                    }
                    else if (inputText.StartsWith("look up"))
                    {
                        minervaSay("According to Wikipedia, " + parseWikipedia(getWebpage("http://en.m.wikipedia.org/w/index.php?search=" + inputText.Substring(7))));
                    }
                    else if (inputText.StartsWith("launch "))
                    {
                        //used to find appdata dir
                        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name; //used to get the current user's username
                        //however, this returns the PC-Name + \\username (Ex. vkoves-PC\\vkoves) and has to be cut
                        int temp = userName.IndexOf('\\');
                        userName = userName.Substring(temp + 1);

                        string location = ""; //use to hold location of the program
                        if (inputText.Substring(7).Equals("notepad"))
                        {
                            System.Diagnostics.Process.Start("notepad.exe"); //recognized by default
                        }
                        else if (inputText.Substring(7).Equals("spotify"))
                        {

                            location = "C:\\Users\\" + userName + "\\AppData\\Roaming\\Spotify\\spotifyLauncher.exe";
                            try
                            {
                                System.Diagnostics.Process.Start(location);
                            }
                            catch (Exception ex)
                            {
                                minervaSay("You don't have Spotify installed. Visit spotify.com to download it, and try again after installation.");
                            }
                        }
                        else if (inputText.Substring(7).Equals("chrome"))
                        {
                            location = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
                            try
                            {
                                System.Diagnostics.Process.Start(location);
                            }
                            catch (Exception ex)
                            {
                                minervaSay("I can't find Chrome. I swear, if you so much as hover over Internet Explorer...");
                            }
                        }
                        else
                        {
                            /* All Snowshoes-specific functionality. This really should be ported to the Windows copy as well. 
                             * Here, Minerva searches through the Apps directory for the active user and returns the shortcuts present there. 
                             * Theoretically, all apps that are installed or used by a Snowshoes user must be located there.
                             * Eventually, there will also be a form asking the user to add things to their apps.
                             * 
                             * Probably.
                             * 
                             * Maybe.
                             * 
                             * Science.
                             */
                            String pathPlease = @"C:\ProjectSnowshoes\User\" + Properties.Settings.Default.username[Properties.Settings.Default.whoIsThisCrazyDoge] + @"\Apps";
                            Boolean foundIt = false;
                            for (int i = 0; i < Directory.GetFiles(pathPlease, "*.*", SearchOption.AllDirectories).Length; i++)
                            {
                                String fullPath = Directory.GetFiles(pathPlease, "*.*", SearchOption.AllDirectories)[i];
                                String onlyFileName = fullPath.Split('\\')[fullPath.Split('\\').Length - 1];
                                String fiInfStrOrig = onlyFileName.Split('.')[0];
                                String fiInfStr = onlyFileName.Split('.')[0].ToLower();
                                //Console.WriteLine(fiInfStr);

                                if (fiInfStr.Contains(inputText.Substring(7)))
                                {
                                    System.Diagnostics.Process.Start(fullPath);
                                    minervaSay("Alright. Launching " + fiInfStrOrig + " now.");
                                }
                            }

                            if (!foundIt)
                            {
                                minervaSay("I looked in your Apps folder, but I can't find " + inputText.Substring(7) + ". If you are really sure you have it, try a different name.");
                            }

                        }

                    }
                    else
                    {
                        //what happens when the user says something not preprogrammed, which may or
                        //may nogt be in memory
                        if (responses.ContainsKey(inputText))
                        {
                            minervaSay(responses[inputText]);
                        }
                        else
                        {
                            noteResponse = true;
                            respondingTo = inputText;
                            minervaSay("I'm not sure how to interpret that. Tell me what I should say to \"" + inputText + "\"" + ".");
                        }
                    }
                } //end note response else
            } //end console command else
        }

        private void query_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
            
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }

        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                //mi.Invoke(notifyIcon1, null);
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString().Equals("Exit"))
            {
                Application.Exit();
            }
            else if (e.ClickedItem.ToString().Equals("About"))
            {
                minervaSay("I am Minerva, hear me roar.");
            }
        }

        private void MinervaSide_Shown(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            if (reminders.ContainsKey(today))
            {
                minervaSay("Hello again, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "!\n\nOh, I just remembered, you have \"" + reminders[today] + "\"");
            }
            else
            {
                minervaSay("Hello again, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "! \n \nI checked your schedule for today, and it looks like you are free. Spend this time wisely!");
            }
        }

        private void linkToSomewhereYouSillyJoven_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(urlToGoTo);
        }

        private String parseBitcoin(String source)
        {
            // Currently uses an element found on CoinBase here. 
            // As of 752015, and pretty long before that as well, this no longer works. Check bug log for information.

            String output = source;
            int start = source.IndexOf("<strong>") + "<strong>".Length;
            int end = source.IndexOf("</strong>");
            int length = end - start;
            output = "start " + start + " end " + end + " length " + length;
            output = source.Substring(start, end - start);
            output = StripTagsCharArray(output);
            return output;
        }

        private void MinervaIntegrated_Load(object sender, EventArgs e)
        {
            
            lookAtMinervaSoSassy.Image.Save(@"C:\ProjectSnowshoes\MinervaOrigin.png");
            
            ImageFactory yetAnotherImgPro = new ImageFactory(); 
            yetAnotherImgPro.Load(@"C:\ProjectSnowshoes\MinervaOrigin.png");
            yetAnotherImgPro.Tint(Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]));

            lookAtMinervaSoSassy.Image = yetAnotherImgPro.Image;

            minervaResponse.ForeColor = Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            minervaResponse.Font = new System.Drawing.Font(Properties.Settings.Default.fontsOfScience[Properties.Settings.Default.whoIsThisCrazyDoge], 16, FontStyle.Regular);

            query.Height = query.Height + 10;
            enterQuery.Height = query.Height;

            query.Top = this.Height - query.Height;
            enterQuery.Top = this.Height - enterQuery.Height;

            this.Top = 0;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;

            if (System.DateTime.Now.Hour < 4)
            {
                minervaResponse.Text = "Good...morning! \n \nYou're up so late, you awoke me from sleep. Up late doing more Snowshoes development, I see?";
            }
            else if (System.DateTime.Now.Hour > 4 && System.DateTime.Now.Hour < 10)
            {
                minervaResponse.Text = "Top of the morning to you, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "!";
            }
            else if (System.DateTime.Now.Hour > 10 && System.DateTime.Now.Hour < 14)
            {
                minervaResponse.Text = "Good day, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "!";
            }
            else if (System.DateTime.Now.Hour > 14 && System.DateTime.Now.Hour < 17)
            {
                minervaResponse.Text = "Good afternoon, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "!";
            }
            else if (System.DateTime.Now.Hour > 17)
            {
                minervaResponse.Text = "Good evening, " + Properties.Settings.Default.nickname[Properties.Settings.Default.whoIsThisCrazyDoge] + "!";
            }

            const int AW_SLIDE = 0X40000;
            const int AW_HOR_POSITIVE = 0X2;
            // User32 and StackOverflow persons, you da real MVPs.
            AnimateWindow(this.Handle, 100, AW_SLIDE | AW_HOR_POSITIVE);


        }

    }
}