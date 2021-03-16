// Programmer: Anita Martin
// Email: amartin98@cnm.edu

// MainWindows.xaml.cs

using System.Collections.Generic;
using System.Windows;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Assignment> tempScores = new List<Assignment>();
        public MainWindow()
        {
            InitializeComponent();
            lbScores.ItemsSource = tempScores;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Student st = new Student();
            st.FirstName = txbFirst.Text;
            st.LastName = txbLast.Text;
            st.StudentNumber = txbStudentNumber.Text;
            st.Major = txbMajor.Text;

            List<Assignment> scores = new List<Assignment>();
            foreach (Assignment score in lbScores.Items)
            {
                scores.Add(score);
            }
            st.Scores = scores;

            txbResults.Text = st.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Assignment assign = new Assignment();
            assign.Title = txbTitle.Text;
            assign.Score = int.Parse(txbScore.Text);
            tempScores.Add(assign);
            lbScores.Items.Refresh();
        }
    }
}
