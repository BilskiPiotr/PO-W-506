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
        Color _kolorWypelnienia;
        int _grubośćLiniiObrysowej;
        Color _kolorLiniiObrysowej;
        int _X, _Y;
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
