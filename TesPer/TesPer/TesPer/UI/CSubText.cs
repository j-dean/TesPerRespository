using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesPer
{
	public class CSubText : TextBox
	{

		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.Alt && e.KeyCode == Keys.R)
			{
				e.SuppressKeyPress = true;
			}
            else if (e.Alt && e.KeyCode == Keys.E)
            {
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.M)
            {
                e.SuppressKeyPress = true;
            }
            base.OnKeyDown(e);
		}
	}
}
