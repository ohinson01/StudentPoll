/* Date: 6/10/2020
 * 
 * Maintenance History:
 *      6/12/2020 - Create program 
 */
using System;
using System.Windows.Forms;
using System.IO;

namespace StudentPoll
{
    public partial class StudentPollForm : Form
    {
        private StreamWriter fileWriter; 
        private StreamReader fileReader;

        public StudentPollForm()
        {
            InitializeComponent();
        } 

        private void doneButton_Click(object sender, EventArgs e)
        {
            int[] responses = {1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3,
                               2, 3, 3, 2};
            var frequency = new int[6]; 

            DialogResult result;
            string fileName; 
            using(var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; 
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; 
            } 

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); 
                } 
                else
                {
                    try
                    {
                        var output = new FileStream(fileName, FileMode.OpenOrCreate,
                            FileAccess.Write);

                        fileWriter = new StreamWriter(output); 
                        

                        for (var answer = 0; answer < responses.Length; ++answer)
                        {
                            try
                            {
                                fileWriter.Write(++frequency[(responses[answer])]);
                            } 
                            catch (IndexOutOfRangeException ex)
                            {
                                fileWriter.Write(ex.Message);
                                fileWriter.Write($"   responses[{answer}] = {responses[answer]}\n");
                            }  
                        } 
                       
                        fileWriter.Write($"{"Rating"}{"Frequency, 10"}");
                     
                        for (var rating = 1; rating < frequency.Length; ++rating)
                        {
                            fileWriter.Write($"{rating,6}{frequency[rating],10}");
                        }
                    } 
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            } 

            try
            {
                fileWriter?.Close();  
            } 
            catch (IOException)
            {
                MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } 
        }

        private void surveyResultsButton_Click(object sender, EventArgs e)
        {
            DialogResult result; 
            string fileName; 
            string file = outputResultsRichTextBox.Text; 

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; 
            } 

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream input = new FileStream(fileName, FileMode.Open,
                            FileAccess.Read);

                        fileReader = new StreamReader(input);
                        file = fileReader.ReadToEnd();

                        if (file != null)
                        {
                            string[] inputFields = file.Split(' ');
                        }
                        else
                        {
                            fileReader.Close();
                            outputResultsRichTextBox.Clear();

                            MessageBox.Show("No more records in file", string.Empty,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }  
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file", "File Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    } 
                } 
            } 
        } 
    } 
} 
