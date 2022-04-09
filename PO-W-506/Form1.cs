// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System.Drawing;
using System.Windows.Forms;

namespace PO_W_506
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    class Figura
    {
        // deklaracja pól publicznych klasy Figura
        Color _kolorWypelnienia;
        Color _kolorLiniiObrysowej;
        Point _location;
        int _grubośćLiniiObrysowej;

        // deklaracja właściwości pozwalających na
        // manipulowanie wartościami pól prywatnych
        // zadeklarowanych w tej klasie
        public Color KolorWypełnienia
        {
            get { return _kolorWypelnienia; }
            set { _kolorWypelnienia = value; }
        }
        public Color KolorLiniiObrysowej
        {
            get { return _kolorLiniiObrysowej; }
            set { _kolorLiniiObrysowej = value; }
        }
        public int GrubośćLiniiObrysowej
        {
            get { return _grubośćLiniiObrysowej; }
            set { _grubośćLiniiObrysowej = value; }
        }
        public Point Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public int X
        {
            get { return _location.X; }
            set { _location.X = value; }
        }
        public int Y
        {
            get { return _location.Y; }
            set { _location.Y = value; }
        }
    }

    class Grafika2D : Figura
    { }
    class Grafika3D : Figura
    {
        int _Z;
    }
    class Statyczne : Grafika3D
    { }
    class Obrotowe : Grafika3D
    {
        int kierunkiemObrotu;
        float nachylenieOsi;
        float szybkościąObrotu;
    }
}
