using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections_and_Exception_Handling
{
    public partial class FormMovieDatabase : Form
    {
        private const int SUCCESS = 0;
        private const int FOUND = 0;
        private const int EMPTY = 0;
        private const int FIRST = 0;
        private const int ERRORINYEAR = 1;
        private const int NOTFOUND = 1;
        private const int ERRORINTITLE = 2;
        private const int ERRORDIRECTOR = 3;
        private const int ERRORINYEARANDTITLE = 4;
        private const int ERRORINYEARANDDIRECTOR = 5;
        private const int ERRORINTITLEANDDIRECTOR = 6;
        private const int ERRORINYEARTITLEDIRECTOR = 7;
        private const int ERRORARGUMENTEX = 8;

        public FormMovieDatabase()
        {
            InitializeComponent();
            MovieManagement.addInitMovie();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string year = txtAddMovieYear.Text;
            string movieName = txtTitle.Text;
            string director = txtDirector.Text;
            informationBox(MovieManagement.CreateMovie(year, movieName, director));
        }

        private void informationBox(Tuple<int, string> errorCode)
        {
            switch (errorCode.Item1)
            {
                case ERRORINYEAR:
                case ERRORARGUMENTEX:
                    txtAddMovieYear.BackColor = Color.HotPink;
                    txtTitle.BackColor = Color.White;
                    txtDirector.BackColor = Color.White;
                    break;

                case ERRORINTITLE:
                    txtAddMovieYear.BackColor = Color.White;
                    txtTitle.BackColor = Color.HotPink;
                    txtDirector.BackColor = Color.White;
                    break;

                case ERRORDIRECTOR:
                    txtAddMovieYear.BackColor = Color.White;
                    txtTitle.BackColor = Color.White;
                    txtDirector.BackColor = Color.HotPink;
                    break;

                case ERRORINYEARANDTITLE:
                    txtAddMovieYear.BackColor = Color.HotPink;
                    txtTitle.BackColor = Color.HotPink;
                    txtDirector.BackColor = Color.White;
                    break;

                case ERRORINYEARANDDIRECTOR:
                    txtAddMovieYear.BackColor = Color.HotPink;
                    txtTitle.BackColor = Color.White;
                    txtDirector.BackColor = Color.HotPink;
                    break;

                case ERRORINTITLEANDDIRECTOR:
                    txtAddMovieYear.BackColor = Color.White;
                    txtTitle.BackColor = Color.HotPink;
                    txtDirector.BackColor = Color.HotPink;
                    break;

                case ERRORINYEARTITLEDIRECTOR:
                    txtAddMovieYear.BackColor = Color.HotPink;
                    txtTitle.BackColor = Color.HotPink;
                    txtDirector.BackColor = Color.HotPink;
                    break;

                case SUCCESS:
                    txtAddMovieYear.BackColor = Color.White;
                    txtTitle.BackColor = Color.White;
                    txtDirector.BackColor = Color.White;
                    break;
            }

            if (errorCode.Item1 == SUCCESS)
            {
                MessageBox.Show(errorCode.Item2, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (errorCode.Item1 == ERRORARGUMENTEX)
            {
                MessageBox.Show(errorCode.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(errorCode.Item2, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            string year = txtDeleteMovieYear.Text;
            if (MovieManagement.checkDeleteMovie(year).Item1 == FOUND)
            {
                DialogResult result = MessageBox.Show(MovieManagement.checkDeleteMovie(year).Item2, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    MovieManagement.deleteMovie(year);
                    MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(MovieManagement.checkDeleteMovie(year).Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string year = txtSearchYear.Text;
            string result = "";
            if (MovieManagement.trySearchMovie(year, out result).Item1 == FOUND)
            {
                lsbxPrintAll.Items.Clear();
                lsbxPrintAll.Items.Add(MovieManagement.trySearchMovie(year, out result).Item2.Year());
                lsbxPrintAll.Items.Add(MovieManagement.trySearchMovie(year, out result).Item2.MovieName);
                lsbxPrintAll.Items.Add(MovieManagement.trySearchMovie(year, out result).Item2.MovieDirector);
                MessageBox.Show("Movie Found", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            }
            else
            {
                MessageBox.Show("Movie Not Found", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
           lsbxPrintAll.Items.Clear();
           if (MovieManagement.print().Item1 == EMPTY)
           {
               MessageBox.Show(MovieManagement.print().Item2[FIRST], "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
           else
           {
               foreach (string item in MovieManagement.print().Item2)
               {
                   lsbxPrintAll.Items.Add(item);
               }
           }
        }
    }
}
