using ImageProcessor;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSnowshoes
{
    class IconManager
    {
        public Image icoExtReturner(string path, string sfn, bool lgIco)
        {
            if (path.Contains(".lnk") || path.Contains(".exe"))
            {
                return checkAppPreInv(path, sfn, lgIco);
            }
            else if (path.Contains(".wav"))
            {
                return getAlbumArtwork(path,"wav");                
            }
            else if (path.Contains(".mp3"))
            {
                return getAlbumArtwork(path, "mp3");
            }
            else
            {
                if (lgIco)
                {
                    ShellFile sf = ShellFile.FromFilePath(path);
                    sf.Thumbnail.FormatOption = ShellThumbnailFormatOption.IconOnly;
                    Bitmap pfmBitmap = sf.Thumbnail.LargeBitmap;
                    pfmBitmap.MakeTransparent();
                    
                    return pfmBitmap;
                }
                else
                {
                    /*ShellFile sf = ShellFile.FromFilePath(path);
                    return sf.Thumbnail.SmallIcon.ToBitmap();*/

                    return Icon.ExtractAssociatedIcon(path).ToBitmap();

                }
            }
        }

        public Image checkAppPreInv(string pathA, string sfnwow, bool li)
        {
            Boolean friendItWorked = false;
            String friendName = "";
            
            for (int i = 0; i < Properties.Settings.Default.appListIco.Count; i++)
            {
                if (sfnwow.Contains(Properties.Settings.Default.appListIco[i])) {
                    friendName = @"C:\ProjectSnowshoes\System\Media\Icons\Applications\Png\" + Properties.Settings.Default.appListIco[i] + ".png";
                    friendItWorked = true;
                }
            }
            
            if (!friendItWorked) {
                if (li)
                {
                    ShellFile sf = ShellFile.FromFilePath(pathA);
                    sf.Thumbnail.FormatOption = ShellThumbnailFormatOption.Default;
                    Bitmap pfmBitmap = sf.Thumbnail.LargeBitmap;
                    pfmBitmap.MakeTransparent(Color.Black);
                    
                    //return sf.Thumbnail.LargeIcon.ToBitmap();

                    return pfmBitmap;
                }
                else
                {
                    /*ShellFile sf = ShellFile.FromFilePath(pathA);
                    return sf.Thumbnail.SmallIcon.ToBitmap();*/

                    return Icon.ExtractAssociatedIcon(pathA).ToBitmap();

                }
            }
            else
            {
                return Image.FromFile(friendName);
            }
        }

        public Image getAlbumArtwork(string pathMusics, string fileExt)
        {
                //Originally here, but unreachable: return Properties.Resources.TheOpacityIsAlmostReal;
                if (fileExt == "wav")
                {
                    return Image.FromFile(@"C:\ProjectSnowshoes\System\Media\Icons\Player\Wav.png");
                }
                else if (fileExt == "mp3")
                {
                    return Image.FromFile(@"C:\ProjectSnowshoes\System\Media\Icons\Player\Mp3.png");
                }
                else {
                    return Icon.ExtractAssociatedIcon(pathMusics).ToBitmap();
                }
        }


    }
}
