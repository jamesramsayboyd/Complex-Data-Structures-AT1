using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Galileo; // Importing Galileo.dll
using System.Diagnostics;

// James Boyd 30041547
// Cluster - Complex Data Structures Assessment 1
// A Windows Forms App using two LinkedList<Double> and demonstrating the
// efficiency of several search and sort methods

namespace DataProcessing
{
    public partial class DataProcessing : Form
    {
        /// <summary>
        /// Initialises application, sets tooltip messages
        /// Creates a log file for debug and testing output
        /// </summary>
        public DataProcessing()
        {
            InitializeComponent();
            ToolStripMessage(0);
            SetToolTips();
            Stream debugOutput = File.Create("DebugOutput.txt");
            Trace.Listeners.Add(new TextWriterTraceListener(debugOutput));
            Trace.AutoFlush = true;
            Trace.WriteLine("*** Debug Output for MSSS Data Processing application ***");
        }

        #region GLOBAL VARIABLES/METHODS
        /// <summary>
        /// 4.1 Create two data structures using the LinkedList class. The data must be of type "double"
        /// The two LinkedLists are to be declared as global within the public partial class
        /// </summary>
        private LinkedList<double> sensorA = new LinkedList<double>();
        private LinkedList<double> sensorB = new LinkedList<double>();

        /// <summary>
        /// 4.2 Create a method "LoadData" which will populate both LinkedLists. Declare an instance of the Galileo
        /// library in the method and create the appropriate loop construct to populate the two LinkedLists. The
        /// LinkedList size will be hardcoded to 400. Input parameters empty, return type void.
        /// </summary>
        public void LoadData()
        {
            ReadData readData = new ReadData();
            int maxDataSize = 400;
            sensorA.Clear();
            sensorB.Clear();
            for (int i = 0; i < maxDataSize; i++)
            {
                sensorA.AddLast(readData.SensorA((double)numericUpDownMu.Value, (double)numericUpDownSigma.Value));
                sensorB.AddLast(readData.SensorB((double)numericUpDownMu.Value, (double)numericUpDownSigma.Value));
            }
            Trace.WriteLine("");
            Trace.WriteLine("New data set loaded: sigma = " + numericUpDownSigma.Value + ", mu = " + numericUpDownMu.Value);
        }

        /// <summary>
        /// 4.3 Create a custom method called "ShowAllSensorData" which will display both LinkedLists in a ListView.
        /// The input parameters are empty and the return type is void.
        /// </summary>
        public void ShowAllSensorData()
        {
            listView.Items.Clear();
            for (int i = 0; i < sensorA.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(sensorA.ElementAt(i).ToString());
                lvi.SubItems.Add(sensorB.ElementAt(i).ToString());
                listView.Items.Add(lvi);
            }
        }

        /// <summary>
        /// 4.4 Create a button and associated click method that will call the LoadData and ShowAllSensorData methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            EnableControls();
            ClearTextBoxes();
            ShowAllSensorData();
            DisplayListBoxData(sensorA, listBoxA);
            DisplayListBoxData(sensorB, listBoxB);
            ToolStripMessage(1);
        }
        #endregion GLOBAL VARIABLES/METHODS

        #region UTILITIES
        /// <summary>
        /// 4.5 Create a method called “NumberOfNodes” that will return an integer which is the number of 
        /// nodes(elements) in a LinkedList. 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private int NumberOfNodes (LinkedList<double> list)
        {
            return list.Count();
        }

        /// <summary>
        /// 4.6	Create a method called “DisplayListBoxData” that will display the content of a LinkedList 
        /// inside the appropriate ListBox.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="listBoxName"></param>
        private void DisplayListBoxData (LinkedList<double> list, ListBox listBoxName)
        {
            listBoxName.Items.Clear();
            foreach (var datum in list)
            {
                listBoxName.Items.Add(datum);
            }
        }

        /// <summary>
        /// A method that highlights a range of ListBox Items +-2 from the given index
        /// </summary>
        /// <param name="listBoxName"></param>
        /// <param name="index"></param>
        private void SelectListBoxRange (ListBox listBoxName, int index)
        {
            listBoxName.SelectedItems.Clear();
            listBoxName.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            for (int i = index - 3; i <= index + 2; i++)
            {
                if (i < 0)
                {
                    continue;
                }
                if (i >= listBoxName.Items.Count)
                {
                    continue;
                }
                listBoxName.SetSelected(i, true);
            }
        }

        /// <summary>
        /// Code to ensure only numbers can be entered in the Search Target textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearchA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxSearchB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// A method to clear all TextBoxes
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxInsertionA.Clear();
            textBoxInsertionB.Clear();
            textBoxIterativeA.Clear();
            textBoxIterativeB.Clear();
            textBoxRecursiveA.Clear();
            textBoxRecursiveB.Clear();
            textBoxSelectionA.Clear();
            textBoxSelectionB.Clear();
            textBoxSearchA.Clear();
            textBoxSearchB.Clear();
        }

        /// <summary>
        /// Buttons and textboxes are disabled by default for error trapping purposes
        /// and only enabled once data has been loaded
        /// </summary>
        private void EnableControls()
        {
            textBoxSearchA.Enabled = true;
            buttonBinaryIterativeA.Enabled = true;
            buttonBinaryRecursiveA.Enabled = true;
            buttonSelectionSortA.Enabled = true;
            buttonInsertionSortA.Enabled = true;
            textBoxSearchB.Enabled = true;
            buttonBinaryIterativeB.Enabled = true;
            buttonBinaryRecursiveB.Enabled = true;
            buttonSelectionSortB.Enabled = true;
            buttonInsertionSortB.Enabled = true;
            listView.Enabled = true;
            listBoxA.Enabled = true;
            listBoxB.Enabled = true;
            textBoxInsertionA.Enabled = true;
            textBoxInsertionB.Enabled = true;
            textBoxSelectionA.Enabled = true;
            textBoxSelectionB.Enabled = true;
            textBoxIterativeA.Enabled = true;
            textBoxIterativeB.Enabled = true;
            textBoxRecursiveA.Enabled = true;
            textBoxRecursiveB.Enabled = true;
        }

        #endregion UTILITIES

        #region SORT METHODS
        /// <summary>
        /// 4.7	Create a method called “SelectionSort” which has a single input parameter of type LinkedList, 
        /// while the calling code argument is the linkedlist name. 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool SelectionSort (LinkedList<double> list)
        {
            int minimum;
            int maximum = NumberOfNodes(list);
            int i;
            for (i = 0; i < maximum; i++)
            {
                minimum = i;
                for (int j = i + 1; j < maximum; j++)
                {
                    if (list.ElementAt(j) < list.ElementAt(minimum))
                    {
                        minimum = j;
                    }
                }

                LinkedListNode<double> currentMin = list.Find(list.ElementAt(minimum));
                LinkedListNode<double> currentI = list.Find(list.ElementAt(i));
                var temp = currentMin.Value;
                currentMin.Value = currentI.Value;
                currentI.Value = temp;
            }
            return true;
        }

        /// <summary>
        /// 4.8	Create a method called “InsertionSort” which has a single parameter of type LinkedList, 
        /// while the calling code argument is the linkedlist name. 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool InsertionSort (LinkedList<double> list)
        {
            int maximum = NumberOfNodes(list);
            for (int i = 0; i < maximum - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (list.ElementAt(j - 1) > list.ElementAt(j))
                    {
                        LinkedListNode<double> current = list.Find(list.ElementAt(j));
                        LinkedListNode<double> previous = list.Find(list.ElementAt(j - 1));
                        var temp = current.Value;
                        current.Value = previous.Value;
                        previous.Value = temp;
                    }
                }
            }
            return true;
        }
        #endregion SORT METHODS

        #region SEARCH METHODS
        /// <summary>
        /// 4.9	Create a method called “BinarySearchIterative” which has the following four parameters: 
        /// LinkedList, SearchValue, Minimum and Maximum. This method will return an integer of the 
        /// linkedlist element from a successful search or the nearest neighbour value. The calling code 
        /// argument is the linkedlist name, search value, minimum list size and the number of nodes in the list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="searchTarget"></param>
        /// <param name="minimumListSize"></param>
        /// <param name="numberOfNodes"></param>
        /// <returns></returns>
        public int BinarySearchIterative(LinkedList<double> list, int searchTarget, int minimumListSize, int numberOfNodes)
        {
            int minimum = minimumListSize;
            int maximum = numberOfNodes;
            while (minimum <= maximum - 1)
            {
                int middle = (minimum + maximum) / 2;
                if (searchTarget == list.ElementAt(middle))
                {
                    return ++middle;
                }
                else if (searchTarget < list.ElementAt(middle))
                {
                    maximum = middle - 1;
                }
                else
                {
                    minimum = middle + 1;
                }
            }
            return minimum;
        }

        /// <summary>
        /// 4.10	Create a method called “BinarySearchRecursive” which has the following four parameters: 
        /// LinkedList, SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist 
        /// element from a successful search or the nearest neighbour value. The calling code argument is the 
        /// linkedlist name, search value, minimum list size and the number of nodes in the list. 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="searchTarget"></param>
        /// <param name="minimumListSize"></param>
        /// <param name="numberOfNodes"></param>
        /// <returns></returns>
        public int BinarySearchRecursive(LinkedList<double> list, int searchTarget, int minimumListSize, int numberOfNodes)
        {
            int minimum = minimumListSize;
            int maximum = numberOfNodes;
            while (minimum <= maximum - 1)
            {
                int middle = (minimum + maximum) / 2;
                if (searchTarget == list.ElementAt(middle))
                {
                    return middle;
                }
                else if (searchTarget < list.ElementAt(middle))
                {
                    return BinarySearchRecursive(list, searchTarget, minimum, middle - 1);
                }
                else
                {
                    return BinarySearchRecursive(list, searchTarget, middle + 1, maximum);
                }
            }
            return minimum;
        }
        #endregion SEARCH METHODS

        #region UI BUTTON METHODS
        /// <summary>
        /// 4.11	Create four button click methods that will search the LinkedList for a value entered into a 
        /// textbox on the form. The search code must check to ensure the data is sorted, then start a stopwatch 
        /// before calling the search method. Once the search is complete the stopwatch will stop and the number 
        /// of ticks will be displayed in a read only textbox. Finally, the code will call the “DisplayListboxData” 
        /// method and highlight the appropriate number (or the next closest number). 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBinaryIterativeA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearchA.Text))
            {
                if (SelectionSort(sensorA))
                {
                    DisplayListBoxData(sensorA, listBoxA);
                    int searchTarget = int.Parse(textBoxSearchA.Text);
                    var stopwatch = Stopwatch.StartNew();
                    int index = BinarySearchIterative(sensorA, searchTarget, 0, NumberOfNodes(sensorA));
                    stopwatch.Stop();
                    TimeSpan ts = stopwatch.Elapsed;
                    SelectListBoxRange(listBoxA, index);
                    textBoxIterativeA.Text = ts.Ticks.ToString() + " ticks";
                    ToolStripMessage(5);
                    Trace.WriteLine("*Sensor A*, search target " + searchTarget + "* Binary Search time (Iterative): " + ts.Ticks.ToString() + " ticks");
                }
            }
            else
            {
                ToolStripMessage(3);
            }
        }

        private void buttonBinaryRecursiveA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearchA.Text))
            {
                if (SelectionSort(sensorA))
                {
                    DisplayListBoxData(sensorA, listBoxA);
                    int searchTarget = int.Parse(textBoxSearchA.Text);
                    var stopwatch = Stopwatch.StartNew();
                    int index = BinarySearchRecursive(sensorA, searchTarget, 0, NumberOfNodes(sensorA));
                    stopwatch.Stop();
                    TimeSpan ts = stopwatch.Elapsed;
                    SelectListBoxRange(listBoxA, index);
                    textBoxRecursiveA.Text = ts.Ticks.ToString() + " ticks";
                    ToolStripMessage(5);
                    Trace.WriteLine("*Sensor A*, search target " + searchTarget + "* Binary Search time (Recursive): " + ts.Ticks.ToString() + " ticks");
                }
            }
            else
            {
                ToolStripMessage(3);
            }
        }

        private void buttonBinaryIterativeB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearchB.Text))
            {
                if (SelectionSort(sensorB))
                {
                    DisplayListBoxData(sensorB, listBoxB);
                    int searchTarget = int.Parse(textBoxSearchB.Text);
                    var stopwatch = Stopwatch.StartNew();
                    int index = BinarySearchIterative(sensorB, searchTarget, 0, NumberOfNodes(sensorB));
                    stopwatch.Stop();
                    TimeSpan ts = stopwatch.Elapsed;
                    SelectListBoxRange(listBoxB, index);
                    textBoxIterativeB.Text = ts.Ticks.ToString() + " ticks";
                    ToolStripMessage(5);
                    Trace.WriteLine("*Sensor B*, search target " + searchTarget + "* Binary Search time (Iterative): " + ts.Ticks.ToString() + " ticks");
                }
            }
            else
            {
                ToolStripMessage(3);
            }
        }

        private void buttonBinaryRecursiveB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearchB.Text))
            {
                if (SelectionSort(sensorB))
                {
                    DisplayListBoxData(sensorB, listBoxB);
                    int searchTarget = int.Parse(textBoxSearchB.Text);
                    var stopwatch = Stopwatch.StartNew();
                    int index = BinarySearchRecursive(sensorB, searchTarget, 0, NumberOfNodes(sensorB));
                    stopwatch.Stop();
                    TimeSpan ts = stopwatch.Elapsed;
                    SelectListBoxRange(listBoxB, index);
                    textBoxRecursiveB.Text = ts.Ticks.ToString() + " ticks";
                    ToolStripMessage(5);
                    Trace.WriteLine("*Sensor B*, search target " + searchTarget + "* Binary Search time (Recursive): " + ts.Ticks.ToString() + " ticks");
                }
            }
            else
            {
                ToolStripMessage(3);
            }
        }

        /// <summary>
        /// 4.12	Create four button click methods that will sort the LinkedList using the Selection and Insertion 
        /// methods. The button method must start a stopwatch before calling the sort method. Once the sort is complete 
        /// the stopwatch will stop and the number of milliseconds will be displayed in a read only textbox. Finally, 
        /// the code will call the “ShowAllSensorData” method and “DisplayListboxData” for the appropriate sensor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectionSortA_Click(object sender, EventArgs e)
        {
            textBoxSelectionA.Clear();
            var stopwatch = Stopwatch.StartNew();
            SelectionSort(sensorA);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            //ShowAllSensorData();
            DisplayListBoxData(sensorA, listBoxA);
            textBoxSelectionA.Text = ts.Milliseconds.ToString() + " milliseconds";
            ToolStripMessage(4);
            Trace.WriteLine("*Sensor A* Selection Sort time: " + ts.Milliseconds.ToString() + " milliseconds");
        }

        private void buttonInsertionSortA_Click(object sender, EventArgs e)
        {
            textBoxInsertionA.Clear();
            var stopwatch = Stopwatch.StartNew();
            InsertionSort(sensorA);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            //ShowAllSensorData();
            DisplayListBoxData(sensorA, listBoxA);
            textBoxInsertionA.Text = ts.Milliseconds.ToString() + " milliseconds";
            ToolStripMessage(4);
            Trace.WriteLine("*Sensor A* Insertion Sort time: " + ts.Milliseconds.ToString() + " milliseconds");
        }

        private void buttonSelectionSortB_Click(object sender, EventArgs e)
        {
            textBoxSelectionB.Clear();
            var stopwatch = Stopwatch.StartNew();
            SelectionSort(sensorB);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            //ShowAllSensorData();
            DisplayListBoxData(sensorB, listBoxB);
            textBoxSelectionB.Text = ts.Milliseconds.ToString() + " milliseconds";
            ToolStripMessage(4);
            Trace.WriteLine("*Sensor B* Selection Sort time: " + ts.Milliseconds.ToString() + " milliseconds");
        }

        private void buttonInsertionSortB_Click(object sender, EventArgs e)
        {
            textBoxInsertionB.Clear();
            var stopwatch = Stopwatch.StartNew();
            InsertionSort(sensorB);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            //ShowAllSensorData();
            DisplayListBoxData(sensorB, listBoxB);
            textBoxInsertionB.Text = ts.Milliseconds.ToString() + " milliseconds";
            ToolStripMessage(4);
            Trace.WriteLine("*Sensor B* Insertion Sort time: " + ts.Milliseconds.ToString() + " milliseconds");
        }
        #endregion UI BUTTON METHODS

        #region USER MESSAGING
        private void ToolStripMessage (int number)
        {
            switch (number)
            {
                case 0:
                    // Initial state of program, prompts user to click the button to begin
                    toolStripStatusLabel.Text = "Set Sigma(standard definition) and Mu(mean) values and click 'Load Sensor Data' to begin";
                    break;
                case 1:
                    // User clicks the Load Sensor Data button to generate data using function fromGalileo.dll
                    toolStripStatusLabel.Text = "Data loaded";
                    break;
                case 2:
                    // User clicks a search button before the LinkedList is sorted
                    toolStripStatusLabel.Text = "Data must be sorted before searching";
                    break;
                case 3:
                    // User clicks a search button without entering a number in the Search Target textbox
                    toolStripStatusLabel.Text = "Enter a search target";
                    break;
                case 4:
                    // Data is sorted using Insertion or Selection Sort buttons
                    toolStripStatusLabel.Text = "Data sorted";
                    break;
                case 5:
                    // Search function complete, items have been selected in ListBox
                    toolStripStatusLabel.Text = "Search target highlighted";
                    break;
                default:
                    break;
            }
        }

        private void SetToolTips()
        {
            toolTip.SetToolTip(numericUpDownSigma, "The standard definition value for the data");
            toolTip.SetToolTip(numericUpDownMu, "The mean value for the data");
            toolTip.SetToolTip(buttonLoad, "Load satellite data from Sensors A and B");
            toolTip.SetToolTip(textBoxSearchA, "Enter a number");
            toolTip.SetToolTip(textBoxSearchB, "Enter a number");
            toolTip.SetToolTip(buttonBinaryIterativeA, "Find the entered search target using an iterative Binary Search algorithm");
            toolTip.SetToolTip(buttonBinaryIterativeB, "Find the entered search target using an iterative Binary Search algorithm");
            toolTip.SetToolTip(buttonBinaryRecursiveA, "Find the entered search target using a recursive Binary Search algorithm");
            toolTip.SetToolTip(buttonBinaryRecursiveB, "Find the entered search target using a recursive Binary Search algorithm");
            toolTip.SetToolTip(textBoxIterativeA, "The time taken for the iterative Binary Search operation (in ticks)");
            toolTip.SetToolTip(textBoxIterativeB, "The time taken for the iterative Binary Search operation (in ticks)");
            toolTip.SetToolTip(textBoxRecursiveA, "The time taken for the recursive Binary Search operation (in ticks)");
            toolTip.SetToolTip(textBoxRecursiveB, "The time taken for the recursive Binary Search operation (in ticks)");
            toolTip.SetToolTip(buttonSelectionSortA, "Sort the data using a Selection Sort algorithm");
            toolTip.SetToolTip(buttonSelectionSortB, "Sort the data using a Selection Sort algorithm");
            toolTip.SetToolTip(buttonInsertionSortA, "Sort the data using a Insertion Sort algorithm");
            toolTip.SetToolTip(buttonInsertionSortB, "Sort the data using a Insertion Sort algorithm");
            toolTip.SetToolTip(textBoxSelectionA, "The time taken for the Selection Sort operation (in milliseconds)");
            toolTip.SetToolTip(textBoxSelectionB, "The time taken for the Selection Sort operation (in milliseconds)");
            toolTip.SetToolTip(textBoxInsertionA, "The time taken for the Insertion Sort operation (in milliseconds)");
            toolTip.SetToolTip(textBoxInsertionB, "The time taken for the Insertion Sort operation (in milliseconds)");
        }
        #endregion USER MESSAGING
    }
}
