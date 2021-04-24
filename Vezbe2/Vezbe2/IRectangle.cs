using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe2
{
    interface IRectangle
    {
        double Width { get; set; }
        double Length { get; set; }
        double Obim();
        double Povrsina();
        void ShowInfo();
    }
}
