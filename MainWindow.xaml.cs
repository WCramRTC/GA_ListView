using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GA_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declare a list to hold the Student objects
        private List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();

            // Populate the student list and set the ListView's ItemsSource
            PopulateStudents();
            lvDisplayList.ItemsSource = students;

            // Automatically select the first item in the list
            lvDisplayList.SelectedIndex = 0;
        } // MainWindow()

        // Method to populate the student list
        private void PopulateStudents()
        {
            // Add Student objects to the list
            students.Add(new Student("John", "Doe"));
            students.Add(new Student("Jane", "Smith"));
            students.Add(new Student("William", "Cram"));
            students.Add(new Student("Kaiser", "Perminente"));
            students.Add(new Student("Richard", "Branson"));
            // Add more students as needed
        } // PopulateStudents

        // Event handler for when a different item in the ListView is selected
        private void lvDisplayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Check if the selected index is valid (not -1)
            if (lvDisplayList.SelectedIndex != -1)
            {
                // Retrieve the selected Student object
                Student selectedStudent = students[lvDisplayList.SelectedIndex];

                // Display a MessageBox showing the full name of the selected student
                MessageBox.Show($"Full Name: {selectedStudent.FirstName} {selectedStudent.LastName}");
            }
        } // lvlDisplayList_SelectionChanged


    } // class
} // namespace
