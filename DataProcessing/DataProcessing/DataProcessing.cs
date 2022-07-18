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

// James Boyd 30041547
// Cluster - Complex Data Structures Assessment 1
// A Windows Forms App using two LinkedList<Double> and demonstrating the
// efficiency of several search and sort methods

namespace DataProcessing
{
    public partial class DataProcessing : Form
    {
        public DataProcessing()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 4.1 Create two data structures using the LinkedList class. The data must be of type "double"
        /// The two LinkedLists are to be declared as global within the public partial class
        /// </summary>
        LinkedList<double> sensorA = new LinkedList<double>();
        LinkedList<double> sensorB = new LinkedList<double>();

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
                sensorA.AddLast(readData.SensorA(mu:i, sigma:i));
                sensorB.AddLast(readData.SensorB(mu:i, sigma:i));
            }
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
            ShowAllSensorData();
        }

        #region UTILITIES
        /// <summary>
        /// 4.5 Create a method called “NumberOfNodes” that will return an integer which is the number of 
        /// nodes(elements) in a LinkedList. 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="listBoxName"></param>
        /// <returns></returns>
        private int NumberOfNodes (LinkedList<double> list, string listBoxName)
        {
            return list.Count();
        }

        /// <summary>
        /// 4.6	Create a method called “DisplayListboxData” that will display the content of a LinkedList 
        /// inside the appropriate ListBox.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="listBoxName"></param>
        private void DisplayListboxData (LinkedList<double> list, ListBox listBoxName)
        {
            listBoxName.Items.Clear();
            foreach (var datum in list)
            {
                listBoxName.Items.Add(datum);
            }
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
            return 0;
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
            return 0;
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

        }

        private void buttonBinaryRecursiveA_Click(object sender, EventArgs e)
        {

        }

        private void buttonBinaryIterativeB_Click(object sender, EventArgs e)
        {

        }

        private void buttonBinaryRecursiveB_Click(object sender, EventArgs e)
        {

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

        }

        private void buttonInsertionSortA_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectionSortB_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsertionSortB_Click(object sender, EventArgs e)
        {

        }



        #endregion UI BUTTON METHODS

    }
}
