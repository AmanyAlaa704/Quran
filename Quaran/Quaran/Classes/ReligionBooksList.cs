using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaran.Classes
{
   public class ReligionBooksList
    {
        public static List<ReligionBook> religionBooks = new List<ReligionBook>()
        {
          new ReligionBook{id=1,BookName="كتاب الأطلس التاريخي لسيرة الرسول صلى الله عليه وسلم ",FileName="01.pdf"},
          new ReligionBook{id=2,BookName="محمد صلى الله عليه وسلم كأنك تراه ",FileName="02.pdf"},
          new ReligionBook{id=3,BookName="كتاب الأطلس التاريخي لسيرة الرسول صلى الله عليه وسلم ",FileName="01.pdf"},
          new ReligionBook{id=4,BookName="محمد صلى الله عليه وسلم كأنك تراه ",FileName="02.pdf"},

        };
    }
}
