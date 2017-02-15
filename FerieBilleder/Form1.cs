using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerieBilleder {
	public partial class Form1 : Form {

		// Container for the filenames (full path including name)
		string[] arr = new string[0];
		// Index for the array above
		int idx = 0;

		Image prev = null; // Picture at index - 1
		Image curr = null; // Current picture
		Image next = null; // Picture at index + 1

		public Form1() {
			InitializeComponent();
			EventArgs e = new EventArgs();
			Form1_SizeChanged(this, e);  // Updates the picturebox
		}

		/// <summary>
		/// Responsible for both updating the index as well as updating
		/// the picture shown. Out of index errors are merely handled 
		/// by a default catch and writing out to the status strip.
		/// </summary>
		/// <param name="goingForward">True for going forward, false for backwards</param>
		/// <param name="step">Number of pictures to move</param>
		private void UpdatePicture(bool goingForward, int step) {
			try {
				// Checks if the step is 1, so we can use the buffer
				if (step == 1) {
					if (goingForward) {
						pictureBox.Image = next; // Using the next picture. Sets this first to please user (performance)
						prev = (Image)curr.Clone(); // Sets the previous buffer to the current while curr is still valid
						curr = (Image)next.Clone(); // Updated curr to being the next (set 2 lines above)
						idx++; 
						if (idx + 1 < arr.Length) { // checks if the next position is valid
							next = Image.FromFile(arr[idx + 1]);
						}
					} else {
						pictureBox.Image = prev; // Using the prev picture. Sets this first to please user (performance)
						next = curr; // Sets the next buffer to the current while curr is still valid
						curr = prev; // Updated curr to being prev (set 2 lines above)
						idx--;
						if (idx - 1 >= 0) { // checks if the next position is valid
							prev = Image.FromFile(arr[idx - 1]);
						}
						
					}
				} else { // if 0 or more than 1 steps then it's either first load or more than with a buffer
					if (goingForward) {
						idx += step;
					} else {
						idx -= step;
					}

					// Sets curr first, to please user (performance)
					curr = Image.FromFile(arr[idx]);
					pictureBox.Image = curr;

					// Sets prev and next if valid positions
					if (idx - 1 >= 0) {
						prev = Image.FromFile(arr[idx - 1]);
					}
					if (idx + 1 < arr.Length) {
						next = Image.FromFile(arr[idx + 1]);
					}

				}
				statusStrip1.Items[1].Text = ""; // If we have made it so far, we remove previous status messages
				statusStrip1.Items[0].Text = "[" + (idx+1) + "/" + arr.Length.ToString() + "] " + arr[idx]; // Update filename
			} catch (Exception ex) {
				statusStrip1.Items[1].Text = "Error: " + ex.Message;
			}
		}

		/// <summary>
		/// Copy current picture from source directory to destination directory
		/// </summary>
		private void Copy() {
			
			// Error messages if dirs have not been set
			if (btnInput.Text == "Select directory") {
				MessageBox.Show("You must select an input directory");
			} else if (btnOutput.Text == "Select directory") {
				MessageBox.Show("You must select an output directory");
			} else {
				// Attempt a copy
				try {
					File.Copy(arr[idx], arr[idx].Replace(btnInput.Text, btnOutput.Text)); // Replaces the full path with the input and output dirs
					statusStrip1.Items[1].Text = "Copied";
				} catch (Exception ex) {
					statusStrip1.Items[1].Text = "Error: " + ex.Message;
				}
			}
		}

		/// <summary>
		/// Purpose is to load the source directory - where the pictures are loaded
		/// and from which they should be copied
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnInput_Click(object sender, EventArgs e) {
			if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				btnInput.Text = folderBrowserDialog.SelectedPath;

				// Loads file info to array
				DirectoryInfo di = new DirectoryInfo(btnInput.Text);
				FileInfo[] fi = di.GetFiles(txtMask.Text);
				arr = new string[fi.Length];

				// Uses only the full name (for display and easy replace at copy command)
				for (int i = 0; i < arr.Length; i++) {
					arr[i] = fi[i].FullName;
				}

				idx = 0;
				UpdatePicture(true,0); // Shows picture and loads also next
			}
		}

		/// <summary>
		/// The output directory - to where pictures should be copied
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOutput_Click(object sender, EventArgs e) {
			if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				btnOutput.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void Form1_SizeChanged(object sender, EventArgs e) {
			// Some calculations for finding out how large the picture box should be
			int padding = pictureBox.Location.X;
			int topRight = pictureBox.Location.Y;

			int width = this.Size.Width - 2 * padding; // Allows some padding by subtracting the width
			int height = this.Size.Height - (topRight + 50 + padding); // Allows some padding and allows space for the statusstrip

			pictureBox.Width = width;
			pictureBox.Height = height;
		}

		#region menu moving
		private void bACKToolStripMenuItem_Click(object sender, EventArgs e) {
			UpdatePicture(false, 1);
		}

		private void fORWARDToolStripMenuItem_Click(object sender, EventArgs e) {
			UpdatePicture(true, 1);
		}

		private void cOPYToolStripMenuItem_Click(object sender, EventArgs e) {
			Copy();
		}
		#endregion

		#region Jumping
		private void button1_Click(object sender, EventArgs e) {
			UpdatePicture(false, 10);
		}

		private void button2_Click(object sender, EventArgs e) {
			UpdatePicture(true, 10);
		}

		private void button3_Click(object sender, EventArgs e) {
			UpdatePicture(true, 20);
		}

		private void button4_Click(object sender, EventArgs e) {
			UpdatePicture(true, 50);
		}
		#endregion

		private void sTATUSToolStripMenuItem_Click(object sender, EventArgs e) {
			string txt = "Made by Kim Bahir Andersen " + Environment.NewLine;
			txt += "Feel free to contact me on kim@bahir.dk " + Environment.NewLine;
			txt += "with comments, feedback or suggestions";

			MessageBox.Show(txt);
		}

		/// <summary>
		/// Jump button, so we can go to a random position in the array
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPosition_Click(object sender, EventArgs e) {
			int position = 0;
			// We try to check if it's a valid int
			if (int.TryParse(txtPosition.Text, out position)) {
				if (position - 1 >= 0 && position - 1 < arr.Length) {
					idx = position - 1;
					UpdatePicture(true, 0);
				} else {
					MessageBox.Show("You must enter an integer between 1 and " + arr.Length + " in the box to the left");
				}
			} else {
				MessageBox.Show("You must enter an integer between 1 and " + arr.Length + " in the box to the left");
			}
		}
	}
}