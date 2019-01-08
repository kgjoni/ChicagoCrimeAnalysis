﻿using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace ChicagoCrime
{
  public partial class Form1 : Form
  {
     public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.clearForm();
    }

    private bool fileExists(string filename)
    {
      if (!System.IO.File.Exists(filename))
      {
        string msg = string.Format("Input file not found: '{0}'",
          filename);

        MessageBox.Show(msg);
        return false;
      }

      // exists!
      return true;
    }

    private void clearForm()
    {
      this.chart.Series.Clear();
      this.chart.Titles.Clear();
      this.chart.Legends.Clear();
    }

    private void cmdByYear_Click(object sender, EventArgs e)
    {
      //
      // Check to make sure database filename in text box actually exists:
      //
      string filename = this.txtFilename.Text;

      if (!fileExists(filename))
        return;

      this.Cursor = Cursors.WaitCursor;

      clearForm();

      //
      // Retrieve data from database:
      //

      //
      // ????????????????
      //



      //
      // Build a set of (x,y) points for plotting:
      //
      List<int> X = new List<int>();
      List<int> Y = new List<int>();

      //foreach (DataRow row in ds.Tables["TABLE"].Rows)
      //{
      //  X.Add(Convert.ToInt32(row["Year"]));
      //  Y.Add(Convert.ToInt32(row["Total"]));
      //}

      //
      // now graph as a line chart:
      //
      this.chart.Titles.Add("Total # of Crimes Per Year");

      var series = this.chart.Series.Add("total # of crimes");

      series.ChartType = SeriesChartType.Line;

      for (int i = 0; i < X.Count; ++i)
      {
        series.Points.AddXY(X[i], Y[i]);
      }

      var legend = new Legend();
      legend.Docking = Docking.Top;
      this.chart.Legends.Add(legend);

      // 
      // done:
      //
      this.Cursor = Cursors.Default;
    }

    private void cmdArrested_Click(object sender, EventArgs e)
    {
      //
      // Check to make sure database filename in text box actually exists:
      //
      string filename = this.txtFilename.Text;

      if (!fileExists(filename))
        return;

      this.Cursor = Cursors.WaitCursor;

      clearForm();

      //
      // Retrieve data from database:
      //

      //
      // ????????????????
      //
      // NOTE: you can do this with one SQL query by summing the
      // Arrested column.  Alternatively, you can execute 2 queries,
      // one to get the total counts, and then another to just 
      // count where an arrest was made.
      //




      //
      // Build a set of (x,y) points for plotting:
      //
      List<int> X = new List<int>();
      List<int> Y1 = new List<int>();
      List<int> Y2 = new List<int>();

      //foreach (DataRow row in ds.Tables["TABLE"].Rows)
      //{
      //  X.Add(Convert.ToInt32(row["Year"]));
      //  Y1.Add(Convert.ToInt32(row["Total"]));
      //  Y2.Add(Convert.ToInt32(row["Arrested"]));
      //}

      //
      // now graph as a line chart:
      //
      this.chart.Titles.Add("Total # of Crimes Per Year vs. Number Arrested");

      var series = this.chart.Series.Add("total # of crimes");

      series.ChartType = SeriesChartType.Line;

      for (int i = 0; i < X.Count; ++i)
      {
        series.Points.AddXY(X[i], Y1[i]);
      }

      var series2 = this.chart.Series.Add("# arrested");

      series2.ChartType = SeriesChartType.Line;

      for (int i = 0; i < X.Count; ++i)
      {
        series2.Points.AddXY(X[i], Y2[i]);
      }

      var legend = new Legend();
      legend.Docking = Docking.Top;
      this.chart.Legends.Add(legend);

      //
      // done:
      //
      this.Cursor = Cursors.Default;
    }

    private void cmdOneArea_Click(object sender, EventArgs e)
    {
      //
      // Check to make sure database filename in text box actually exists:
      //
      string filename = this.txtFilename.Text;

      if (!fileExists(filename))
        return;

      this.Cursor = Cursors.WaitCursor;

      clearForm();

      //
      // Retrieve data from database:
      //

      //
      // ????????????????
      //
      // NOTE: you might be able to do this with one SQL query,
      // but probably easier to just execute 2 queries: one to
      // get the total counts, and then another to get the counts
      // for the area specified by the user.  You may assume the
      // area name entered by the user exists (though FYI using a 
      // different type of join yields the necessary counts of 0
      // for plotting, and then it always works no matter what the
      // user enters).
      //





      //
      // Build a set of (x,y) points for plotting:
      //
      List<int> X = new List<int>();
      List<int> Y1 = new List<int>();
      List<int> Y2 = new List<int>();

      //foreach (DataRow row in ds.Tables["TABLE"].Rows)
      //{
      //  X.Add(Convert.ToInt32(row["Year"]));
      //  Y1.Add(Convert.ToInt32(row["Total"]));
      //}

      //foreach (DataRow row in ds2.Tables["TABLE"].Rows)
      //{
      //  Y2.Add(Convert.ToInt32(row["Total"]));
      //}

      //
      // now graph as a line chart:
      //
      this.chart.Titles.Add("Total # of Crimes Per Year vs. Particular Area");

      var series = this.chart.Series.Add("total # of crimes");

      series.ChartType = SeriesChartType.Line;

      for (int i = 0; i < X.Count; ++i)
      {
        series.Points.AddXY(X[i], Y1[i]);
      }

      var series2 = this.chart.Series.Add("# in this area");

      series2.ChartType = SeriesChartType.Line;

      for (int i = 0; i < X.Count; ++i)
      {
        series2.Points.AddXY(X[i], Y2[i]);
      }

      var legend = new Legend();
      legend.Docking = Docking.Top;
      this.chart.Legends.Add(legend);

      //
      // done:
      //
      this.Cursor = Cursors.Default;
    }

    private void cmdChicagoAreas_Click(object sender, EventArgs e)
    {
      //
      // Check to make sure database filename in text box actually exists:
      //
      string filename = this.txtFilename.Text;

      if (!fileExists(filename))
        return;

      this.Cursor = Cursors.WaitCursor;

      clearForm();

      //
      // Retrieve data from database:
      //
      //
      // ????????????????
      //





      //
      // Build a set of (x,y) points for plotting:
      //
      List<int> X = new List<int>();
      List<int> Y = new List<int>();

      //foreach (DataRow row in ds.Tables["TABLE"].Rows)
      //{
      //  X.Add(Convert.ToInt32(row["Area"]));
      //  Y.Add(Convert.ToInt32(row["Total"]));
      //}

      //
      // now graph as a line chart:
      //
      this.chart.Titles.Add("Total # of Crimes in each Chicago Area");

      var series = this.chart.Series.Add("total # of crimes");

      series.ChartType = SeriesChartType.Line;

      for (int i = 0; i < X.Count; ++i)
      {
        series.Points.AddXY(X[i], Y[i]);
      }

      var legend = new Legend();
      legend.Docking = Docking.Top;
      this.chart.Legends.Add(legend);

      //
      // done:
      //
      this.Cursor = Cursors.Default;
    }

  }//class
}//namespace
