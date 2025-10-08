using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesPer
{
	public class CSubRichText : RichTextBox
	{
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
			}

			if (e.Control && e.KeyCode == Keys.E)
			{
				e.Handled = true;
			}

			if (e.Control && e.KeyCode == Keys.R)
			{
				e.Handled = true;
			}


			if (e.Alt && e.KeyCode == Keys.T)
			{
				e.Handled = true;
			}


			if (e.Alt && e.KeyCode == Keys.R)
			{
				e.SuppressKeyPress = true;
			}

			base.OnKeyDown(e);
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				SelectionStart = this.Text.Length;
				this.ScrollToCaret();
			}

			base.OnKeyPress(e);
		}
	}
}
