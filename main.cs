using System;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

public class Form1 : Form{
  // Object declaration
  // Main Panel
  public Label label_aplication_name = new Label();
  // Category
  public Button button_search_category_table = new Button();
  public Button button_clear_search_category_table = new Button();
  public Panel main_panel = new Panel();
  public DataGridView category_table = new DataGridView();
  public TextBox category_search_textBox = new TextBox();
  public Label label_category_table = new Label();
  public Label label_category_action_name = new Label();
  public Button button_delete_select_category = new Button();
  public Button button_edit_category = new Button();
  public Button button_add_category = new Button();
  public Button button_save_add_category = new Button();
  public Button button_cancel_add_category = new Button();
  public TextBox textBox_add_category_name = new TextBox();
  // Item
  public Label label_item_table = new Label();
  public DataGridView item_table = new DataGridView();
  public TextBox item_search_textBox = new TextBox();
  public Button button_search_item_table = new Button();
  public Button button_clear_search_item_table = new Button();
  public Label label_item_action_name = new Label();
  public Label label_item_ID = new Label();
  public Label label_item_Name = new Label();
  public Label label_item_Producer = new Label();
  public Label label_item_Serial_number = new Label();
  public Label label_item_Model_number = new Label();
  public Label label_item_Description = new Label();
  public Label label_item_Count = new Label();
  public Label label_item_Dimensions = new Label();
  public Label label_item_Weight = new Label();
  public TextBox textBox_item_ID = new TextBox();
  public TextBox textBox_item_Name = new TextBox();
  public TextBox textBox_item_Producer = new TextBox();
  public TextBox textBox_item_Serial_number = new TextBox();
  public TextBox textBox_item_Model_number = new TextBox();
  public TextBox textBox_item_Description = new TextBox();
  public TextBox textBox_item_Count = new TextBox();
  public TextBox textBox_item_Dimensions = new TextBox();
  public TextBox textBox_item_Weight = new TextBox();
  public Button button_delete_select_item = new Button();
  public Button button_add_item = new Button();
  public Button button_edit_select_item = new Button();
  public Button button_save_new_item = new Button();
  public Button button_cancel_new_item = new Button();

  // Variable declaration
  public string category_search = "";
  public string selected_category_file = "";
  public string item_search = "";
  public string change_category_status = "";
  public string change_item_status = "";

  // Form declaration
  public Form1(){
    // Window setting
    this.Size = new Size(1280,720);
    this.Text = "Inventory Management System";
    this.MaximizeBox = false;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;

    // Main Panel --------------------------------------------------------------
    // Category ----------------------------------------------------------------
    // Panel declaration
    main_panel.Location = new Point(0,0);
    main_panel.Size = new Size(1280,720);
    this.Controls.Add(main_panel);

    // Label app Name
    label_aplication_name.Size = new Size(300,50);
    label_aplication_name.Location = new Point(20,10);
    label_aplication_name.Text = "I.M.System";
    label_aplication_name.Font = new Font("Arial", 30, FontStyle.Bold);
    main_panel.Controls.Add(label_aplication_name);

    // TextBox category_search_textBox declaration
    category_search_textBox.Size = new Size(178,24);
    category_search_textBox.Location = new Point(100,78);
    category_search_textBox.Multiline = false;
    main_panel.Controls.Add(category_search_textBox);

    // Button button_search_category_table declaration
    button_search_category_table.Size = new Size(50,24);
    button_search_category_table.Location = new Point(280,76);
    button_search_category_table.Text = "Search";
    button_search_category_table.Click += new EventHandler(button_search_category_table_Click);
    main_panel.Controls.Add(button_search_category_table);

    // Button button_clear_search_category_table declaration
    button_clear_search_category_table.Size = new Size(30,24);
    button_clear_search_category_table.Location = new Point(331,76);
    button_clear_search_category_table.Text = "(c)";
    button_clear_search_category_table.Click += new EventHandler(button_clear_search_category_table_Click);
    main_panel.Controls.Add(button_clear_search_category_table);

    // Category table declaration
    label_category_table.Size = new Size(80,20);
    label_category_table.Location = new Point(20,80);
    label_category_table.Text = "Database";
    main_panel.Controls.Add(label_category_table);
    category_table_declaration(main_panel);

    // Get file list to category_table
    fill_table_of_file_list();

    // Button Category
    button_add_category.Size = new Size(100,24);
    button_add_category.Location = new Point(9,505);
    button_add_category.Text = "Add category";
    button_add_category.Click += new EventHandler(button_add_category_Click);
    button_add_category.Enabled = true;
    main_panel.Controls.Add(button_add_category);

    button_edit_category.Size = new Size(100,24);
    button_edit_category.Location = new Point(135,505);
    button_edit_category.Text = "Edit name";
    button_edit_category.Click += new EventHandler(button_edit_category_Click);
    button_edit_category.Enabled = false;
    main_panel.Controls.Add(button_edit_category);

    button_delete_select_category.Size = new Size(100,24);
    button_delete_select_category.Location = new Point(261,505);
    button_delete_select_category.Text = "Delete category";
    button_delete_select_category.Click += new EventHandler(button_delete_select_category_Click);
    button_delete_select_category.Enabled = false;
    main_panel.Controls.Add(button_delete_select_category);

    // Category action name
    label_category_action_name.Size = new Size(260,20);
    label_category_action_name.Location = new Point(59,560);
    label_category_action_name.Text = "";
    label_category_action_name.Font = new Font("Arial", 9, FontStyle.Bold);
    main_panel.Controls.Add(label_category_action_name);

    textBox_add_category_name.Size = new Size(250,24);
    textBox_add_category_name.Location = new Point(59,580);
    textBox_add_category_name.Text = "";
    textBox_add_category_name.ReadOnly = true;
    main_panel.Controls.Add(textBox_add_category_name);

    button_save_add_category.Size = new Size(100,24);
    button_save_add_category.Location = new Point(79,607);
    button_save_add_category.Text = "Save";
    button_save_add_category.Enabled = false;
    button_save_add_category.Click += new EventHandler(button_save_add_category_Click);
    main_panel.Controls.Add(button_save_add_category);

    button_cancel_add_category.Size = new Size(100,24);
    button_cancel_add_category.Location = new Point(181,607);
    button_cancel_add_category.Text = "Cancel";
    button_cancel_add_category.Enabled = false;
    button_cancel_add_category.Click += new EventHandler(button_cancel_add_category_Click);
    main_panel.Controls.Add(button_cancel_add_category);

    // Item --------------------------------------------------------------------
    // TextBox item_search_textBox declaration
    item_search_textBox.Size = new Size(178,24);
    item_search_textBox.Location = new Point(1005,7);
    item_search_textBox.Multiline = false;
    item_search_textBox.ReadOnly = true;
    main_panel.Controls.Add(item_search_textBox);

    // Button button_search_item_table declaration
    button_search_item_table.Size = new Size(50,24);
    button_search_item_table.Location = new Point(1185,5);
    button_search_item_table.Text = "Search";
    button_search_item_table.Click += new EventHandler(button_search_item_table_Click);
    button_search_item_table.Enabled = false;
    main_panel.Controls.Add(button_search_item_table);

    // Button button_clear_search_item_table declaration
    button_clear_search_item_table.Size = new Size(30,24);
    button_clear_search_item_table.Location = new Point(1236,5);
    button_clear_search_item_table.Text = "(c)";
    button_clear_search_item_table.Click += new EventHandler(button_clear_search_item_table_Click);
    button_clear_search_item_table.Enabled = false;
    main_panel.Controls.Add(button_clear_search_item_table);

    // Item table declaration
    label_item_table.Size = new Size(600,20);
    label_item_table.Location = new Point(380,9);
    label_item_table.Text = "";
    label_item_table.Font = new Font("Arial", 11, FontStyle.Bold);
    main_panel.Controls.Add(label_item_table);
    item_table_declaration(main_panel);

    // Item description
    item_description_labels();

    // Button add item (450,478)
    button_add_item.Size = new Size(100,24);
    button_add_item.Location = new Point(1166,477);
    button_add_item.Text = "Add item";
    button_add_item.Click += new EventHandler(button_add_item_Click);
    button_add_item.Enabled = false;
    main_panel.Controls.Add(button_add_item);

    // Button edit select item
    button_edit_select_item.Size = new Size(100,24);
    button_edit_select_item.Location = new Point(1166,506);
    button_edit_select_item.Text = "Edit item";
    button_edit_select_item.Click += new EventHandler(button_edit_select_item_Click);
    button_edit_select_item.Enabled = false;
    main_panel.Controls.Add(button_edit_select_item);

    // Button delete select item
    button_delete_select_item.Size = new Size(100,24);
    button_delete_select_item.Location = new Point(1166,535);
    button_delete_select_item.Text = "Delete item";
    button_delete_select_item.Click += new EventHandler(button_delete_select_item_Click);
    button_delete_select_item.Enabled = false;
    main_panel.Controls.Add(button_delete_select_item);

    button_save_new_item.Size = new Size(100,24);
    button_save_new_item.Location = new Point(1166,626);
    button_save_new_item.Text = "Save";
    button_save_new_item.Click += new EventHandler(button_save_new_item_Click);
    button_save_new_item.Enabled = false;
    main_panel.Controls.Add(button_save_new_item);

    button_cancel_new_item.Size = new Size(100,24);
    button_cancel_new_item.Location = new Point(1166,655); //602
    button_cancel_new_item.Text = "Cancel";
    button_cancel_new_item.Click += new EventHandler(button_cancel_new_item_Click);
    button_cancel_new_item.Enabled = false;
    main_panel.Controls.Add(button_cancel_new_item);
  }

  // button_save_new_item action
  private void button_cancel_new_item_Click(object sender, EventArgs e){
    label_item_action_name.Text = "Item overview";
    button_add_category.Enabled = true;
    button_edit_category.Enabled = true;
    button_delete_select_category.Enabled = true;
    category_search_textBox.ReadOnly = false;
    button_search_category_table.Enabled = true;
    button_clear_search_category_table.Enabled = true;
    button_add_item.Enabled = true;
    if(change_item_status == "add"){
      button_edit_select_item.Enabled = false;
      button_delete_select_item.Enabled = false;
    }else{
      button_edit_select_item.Enabled = true;
      button_delete_select_item.Enabled = true;
    }
    item_search_textBox.ReadOnly = false;
    button_search_item_table.Enabled = true;
    button_clear_search_item_table.Enabled = true;
    category_table.Enabled = true;
    item_table.Enabled = true;
    disable_editing_item_textBox();
    button_save_new_item.Enabled = false;
    button_cancel_new_item.Enabled = false;

  }

  // button_save_new_item action
  private void button_save_new_item_Click(object sender, EventArgs e){
    label_item_action_name.Text = "Item overview";
    button_add_category.Enabled = true;
    button_edit_category.Enabled = true;
    button_delete_select_category.Enabled = true;
    category_search_textBox.ReadOnly = false;
    button_search_category_table.Enabled = true;
    button_clear_search_category_table.Enabled = true;
    button_add_item.Enabled = true;
    button_edit_select_item.Enabled = false;
    button_delete_select_item.Enabled = false;
    item_search_textBox.ReadOnly = false;
    button_search_item_table.Enabled = true;
    button_clear_search_item_table.Enabled = true;
    category_table.Enabled = true;
    item_table.Enabled = true;
    disable_editing_item_textBox();
    button_save_new_item.Enabled = false;
    button_cancel_new_item.Enabled = false;

    if(change_item_status == "add"){
      add_new_item_to_file();
    }

    if(change_item_status == "edit"){
      int selected_row = int.Parse(item_table.Rows[item_table.CurrentCell.RowIndex].Cells[0].Value.ToString()) - 1;
      List<string> list_of_item = new List<string>();
      int count_row = 0;
      foreach (string line in System.IO.File.ReadLines(@"ims-data\" + selected_category_file)){
        list_of_item.Add(line);
      }
      String[] lines = list_of_item.ToArray();
      File.Delete(@"ims-data\" + selected_category_file);
      using (StreamWriter sw = File.CreateText(@"ims-data\" + selected_category_file)){
        count_row = 0;
        foreach(string line in lines){
          if(count_row != selected_row){
            sw.WriteLine(line);
          }
          count_row++;
        }
      }
      add_new_item_to_file();
    }
  }

  private void add_new_item_to_file(){
    File.AppendAllText(@"ims-data\" + selected_category_file,
      textBox_item_Name.Text.ToString().Replace(';', ',') + ";" +
      textBox_item_Producer.Text.ToString().Replace(';', ',') + ";" +
      textBox_item_Serial_number.Text.ToString().Replace(';', ',') + ";" +
      textBox_item_Model_number.Text.ToString().Replace(';', ',') + ";" +

      textBox_item_Description.Text.ToString().Replace(System.Environment.NewLine," ").Replace(';', ',') + ";" +

      textBox_item_Count.Text.ToString().Replace(';', ',') + ";" +
      textBox_item_Dimensions.Text.ToString().Replace(';', ',') + ";" +
      textBox_item_Weight.Text.ToString().Replace(';', ',') + ";\n"
    );
    textBox_item_Description.Text = textBox_item_Description.Text.ToString().Replace(System.Environment.NewLine," ").Replace(';', ',');
    fill_table_of_item_list();
    clear_editing_item_textBox();
  }

  // button_add_item action
  private void button_add_item_Click(object sender, EventArgs e){
    change_item_status = "add";
    label_item_action_name.Text = "Adding an item";
    clear_editing_item_textBox();
    button_add_category.Enabled = false;
    button_edit_category.Enabled = false;
    button_delete_select_category.Enabled = false;
    category_search_textBox.ReadOnly = true;
    button_search_category_table.Enabled = false;
    button_clear_search_category_table.Enabled = false;
    button_add_item.Enabled = false;
    button_edit_select_item.Enabled = false;
    button_delete_select_item.Enabled = false;
    item_search_textBox.ReadOnly = true;
    button_search_item_table.Enabled = false;
    button_clear_search_item_table.Enabled = false;
    category_table.Enabled = false;
    item_table.Enabled = false;
    enable_editing_item_textBox();
    button_save_new_item.Enabled = true;
    button_cancel_new_item.Enabled = true;

  }

  // button_edit_item action
  private void button_edit_select_item_Click(object sender, EventArgs e){
    change_item_status = "edit";
    label_item_action_name.Text = "Editing an item";
    button_add_category.Enabled = false;
    button_edit_category.Enabled = false;
    button_delete_select_category.Enabled = false;
    category_search_textBox.ReadOnly = true;
    button_search_category_table.Enabled = false;
    button_clear_search_category_table.Enabled = false;
    button_add_item.Enabled = false;
    button_edit_select_item.Enabled = false;
    button_delete_select_item.Enabled = false;
    item_search_textBox.ReadOnly = true;
    button_search_item_table.Enabled = false;
    button_clear_search_item_table.Enabled = false;
    category_table.Enabled = false;
    item_table.Enabled = false;
    enable_editing_item_textBox();
    button_save_new_item.Enabled = true;
    button_cancel_new_item.Enabled = true;

  }

  private void disable_editing_item_textBox(){
    textBox_item_ID.ReadOnly = true;
    textBox_item_Name.ReadOnly = true;
    textBox_item_Producer.ReadOnly = true;
    textBox_item_Serial_number.ReadOnly = true;
    textBox_item_Model_number.ReadOnly = true;
    textBox_item_Count.ReadOnly = true;
    textBox_item_Dimensions.ReadOnly = true;
    textBox_item_Weight.ReadOnly = true;
    textBox_item_Description.ReadOnly = true;
  }

  private void enable_editing_item_textBox(){
    textBox_item_ID.ReadOnly = true;
    textBox_item_Name.ReadOnly = false;
    textBox_item_Producer.ReadOnly = false;
    textBox_item_Serial_number.ReadOnly = false;
    textBox_item_Model_number.ReadOnly = false;
    textBox_item_Count.ReadOnly = false;
    textBox_item_Dimensions.ReadOnly = false;
    textBox_item_Weight.ReadOnly = false;
    textBox_item_Description.ReadOnly = false;
  }

  private void clear_editing_item_textBox(){
    textBox_item_ID.Text = "";
    textBox_item_Name.Text = "";
    textBox_item_Producer.Text = "";
    textBox_item_Serial_number.Text = "";
    textBox_item_Model_number.Text = "";
    textBox_item_Count.Text = "";
    textBox_item_Dimensions.Text = "";
    textBox_item_Weight.Text = "";
    textBox_item_Description.Text = "";
  }

  // button_delete_select_item action
  private void button_delete_select_item_Click(object sender, EventArgs e){
    DialogResult dr = MessageBox.Show("Delete item no: " + item_table.Rows[item_table.CurrentCell.RowIndex].Cells[0].Value.ToString() + "?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
    if (dr == DialogResult.Yes)
    {
      int selected_row = int.Parse(item_table.Rows[item_table.CurrentCell.RowIndex].Cells[0].Value.ToString()) - 1;
      List<string> list_of_item = new List<string>();
      int count_row = 0;
      foreach (string line in System.IO.File.ReadLines(@"ims-data\" + selected_category_file)){
        list_of_item.Add(line);
      }
      String[] lines = list_of_item.ToArray();
      File.Delete(@"ims-data\" + selected_category_file);
      using (StreamWriter sw = File.CreateText(@"ims-data\" + selected_category_file)){
        count_row = 0;
        foreach(string line in lines){
          if(count_row != selected_row){
            sw.WriteLine(line);
          }
          count_row++;
        }
      }
      fill_table_of_item_list();
      clear_editing_item_textBox();
      button_edit_select_item.Enabled = false;
      button_delete_select_item.Enabled = false;
    }
  }

  // button_clear_search_item_table action
  private void button_clear_search_item_table_Click(object sender, EventArgs e){
    item_search = "";
    item_search_textBox.Text = "";
    fill_table_of_item_list();
  }

  // button_search_item_table action
  private void button_search_item_table_Click(object sender, EventArgs e){
    if(selected_category_file != ""){
      item_search = item_search_textBox.Text;
      item_table.Rows.Clear();
      int counter = 1;
      // Read the file and fill it line by linein to item table
      foreach (string line in System.IO.File.ReadLines(@"ims-data\" + selected_category_file))
      {
        char[] delimiters = new char[] { ';' };
        string[] parts = line.Split(delimiters);
        string[] row = {
          counter.ToString(),
          parts[0],
          parts[1],
          parts[2],
          parts[3],
          parts[4],
          parts[5],
          parts[6],
          parts[7],
          parts[8]
        };
        foreach (string s in parts){
          if (s.ToUpper().Contains(item_search.ToUpper())){
            item_table.Rows.Add(row);
            break;
          }
        }
        counter++;
      }
    }
  }

  // item_table action
  private void item_table_Click(object sender, EventArgs e){
    try{
      textBox_item_ID.Text =            item_table.Rows[item_table.CurrentCell.RowIndex].Cells[0].Value.ToString();
      textBox_item_Name.Text =          item_table.Rows[item_table.CurrentCell.RowIndex].Cells[1].Value.ToString();
      textBox_item_Producer.Text =      item_table.Rows[item_table.CurrentCell.RowIndex].Cells[2].Value.ToString();
      textBox_item_Serial_number.Text = item_table.Rows[item_table.CurrentCell.RowIndex].Cells[3].Value.ToString();
      textBox_item_Model_number.Text =  item_table.Rows[item_table.CurrentCell.RowIndex].Cells[4].Value.ToString();
      textBox_item_Description.Text =   item_table.Rows[item_table.CurrentCell.RowIndex].Cells[5].Value.ToString();
      textBox_item_Count.Text =         item_table.Rows[item_table.CurrentCell.RowIndex].Cells[6].Value.ToString();
      textBox_item_Dimensions.Text =    item_table.Rows[item_table.CurrentCell.RowIndex].Cells[7].Value.ToString();
      textBox_item_Weight.Text =        item_table.Rows[item_table.CurrentCell.RowIndex].Cells[8].Value.ToString();
      button_edit_select_item.Enabled = true;
      button_delete_select_item.Enabled = true;
    }catch (System.Exception){
       MessageBox.Show("No item selected.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  // Fill item table
  private void fill_table_of_item_list(){
    item_table.Rows.Clear();
    int counter = 1;
    // Read the file and fill it line by linein to item table
    foreach (string line in System.IO.File.ReadLines(@"ims-data\" + selected_category_file))
    {
      char[] delimiters = new char[] { ';' };
      string[] parts = line.Split(delimiters);
      string[] row = {
        counter.ToString(),
        parts[0],
        parts[1],
        parts[2],
        parts[3],
        parts[4],
        parts[5],
        parts[6],
        parts[7],
        parts[8]
      };
      item_table.Rows.Add(row);
      counter++;
    }
  }

  // Item table declaration
  private void item_table_declaration(Panel panel){
    // General setting
    item_table.ColumnCount = 9;
    item_table.Name = "Category";
    item_table.Location = new Point(370, 30);
    item_table.Size = new Size(895, 400);
    item_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
    item_table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
    item_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    item_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    item_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    item_table.AllowUserToResizeRows = false;
    item_table.MultiSelect = false;
    item_table.ReadOnly = true;
    item_table.RowHeadersVisible = false;
    item_table.AllowUserToAddRows = false;
    // Column setting
    item_table.Columns[0].Name = "No";
    item_table.Columns[1].Name = "Name";
    item_table.Columns[2].Name = "Producer";
    item_table.Columns[3].Name = "Serial no";
    item_table.Columns[4].Name = "Model No";
    item_table.Columns[5].Name = "Description";
    item_table.Columns[6].Name = "Quantity";
    item_table.Columns[7].Name = "Dimensions";
    item_table.Columns[8].Name = "Weight";
    item_table.Columns[0].DisplayIndex = 0;
    item_table.Columns[1].DisplayIndex = 1;
    item_table.Columns[2].DisplayIndex = 2;
    item_table.Columns[3].DisplayIndex = 3;
    item_table.Columns[4].DisplayIndex = 4;
    item_table.Columns[5].DisplayIndex = 8;
    item_table.Columns[6].DisplayIndex = 5;
    item_table.Columns[7].DisplayIndex = 6;
    item_table.Columns[8].DisplayIndex = 7;
    // Implementation & EventHandler
    item_table.Click += new EventHandler(item_table_Click);
    panel.Controls.Add(item_table);
    item_table.Enabled = false;
  }

  // Fill table of file in directory
  private void fill_table_of_file_list(){
    // Check direcory data
    if(!System.IO.Directory.Exists(@"ims-data\")){
      System.IO.Directory.CreateDirectory(@"ims-data\");
    }
    // Get file list
    category_table.Rows.Clear();
    DirectoryInfo di = new DirectoryInfo(@"ims-data\");
    FileInfo[] files = di.GetFiles("*" + category_search + "*.imsdata");
    int category_count = 1;
    foreach (FileInfo file in files){
      string[] row = {category_count.ToString(), file.Name.ToString().Remove(file.Name.ToString().Length - 8), file.Name};
      category_table.Rows.Add(row);
      category_count++;
    }
    category_table.Refresh();

  }

  // Category table declaration
  private void category_table_declaration(Panel panel){
    // General setting
    category_table.ColumnCount = 3;
    category_table.Name = "Category";
    category_table.Location = new Point(10, 102);
    category_table.Size = new Size(350, 400);
    category_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
    category_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    category_table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
    category_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
    category_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    category_table.AllowUserToResizeRows = false;
    category_table.MultiSelect = false;
    category_table.ReadOnly = true;
    category_table.RowHeadersVisible = false;
    category_table.AllowUserToAddRows = false;
    // Column setting
    category_table.Columns[0].Name = "No";
    category_table.Columns[1].Name = "Name";
    category_table.Columns[2].Name = "File";
    category_table.Columns[2].Visible = false;
    category_table.Columns[0].DisplayIndex = 0;
    category_table.Columns[1].DisplayIndex = 1;
    category_table.Columns[2].DisplayIndex = 2;
    // Implementation & EventHandler
    category_table.Click += new EventHandler(category_table_Click);
    panel.Controls.Add(category_table);
  }

  // button_clear_search_category_table_Click action
  private void button_clear_search_category_table_Click(object sender, EventArgs e){
    category_search = "";
    category_search_textBox.Text = category_search;
    fill_table_of_file_list();
  }

  // button_search_category_table action
  private void button_search_category_table_Click(object sender, EventArgs e){
    category_search = category_search_textBox.Text;
    fill_table_of_file_list();
  }

  // category_table action
  private void category_table_Click(object sender, EventArgs e){
    try{
      item_table.Enabled = true;
      label_item_table.Text = category_table.Rows[category_table.CurrentCell.RowIndex].Cells[1].Value.ToString();
      selected_category_file = category_table.Rows[category_table.CurrentCell.RowIndex].Cells[2].Value.ToString();
      fill_table_of_item_list();
      clear_editing_item_textBox();
      button_add_item.Enabled = true;
      button_edit_select_item.Enabled = false;
      button_delete_select_item.Enabled = false;
      item_search_textBox.ReadOnly = false;
      button_search_item_table.Enabled = true;
      button_clear_search_item_table.Enabled = true;
      button_edit_category.Enabled = true;
      button_delete_select_category.Enabled = true;
    }catch (System.Exception){
       MessageBox.Show("No category selected.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private void button_delete_select_category_Click(object sender, EventArgs e){
    if(File.Exists(@"ims-data\" + category_table.Rows[category_table.CurrentCell.RowIndex].Cells[2].Value.ToString())){
      DialogResult dr = MessageBox.Show("Delete a category: "+category_table.Rows[category_table.CurrentCell.RowIndex].Cells[1].Value.ToString()+"?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
      if (dr == DialogResult.Yes)
      {
        File.Delete(@"ims-data\" + category_table.Rows[category_table.CurrentCell.RowIndex].Cells[2].Value.ToString());
        category_search = "";
        category_search_textBox.Text = category_search;
        fill_table_of_file_list();
        label_item_table.Text = "";
        item_table.Rows.Clear();
        item_table.Enabled = false;
        clear_editing_item_textBox();
        button_add_item.Enabled = false;
        button_edit_select_item.Enabled = false;
        button_delete_select_item.Enabled = false;
        item_search_textBox.ReadOnly = true;
        button_search_item_table.Enabled = false;
        button_clear_search_item_table.Enabled = false;
        button_edit_category.Enabled = false;
        button_delete_select_category.Enabled = false;
      }
    }else{
      MessageBox.Show("No category selected.");
    }
  }

  private void button_edit_category_Click(object sender, EventArgs e){
    change_category_status = "edit";
    textBox_add_category_name.ReadOnly = false;
    button_save_add_category.Enabled = true;
    button_cancel_add_category.Enabled = true;
    button_add_category.Enabled = false;
    button_edit_category.Enabled = false;
    button_delete_select_category.Enabled = false;
    category_search_textBox.ReadOnly = true;
    button_search_category_table.Enabled = false;
    button_clear_search_category_table.Enabled = false;
    category_table.Enabled = false;
    button_add_item.Enabled = false;
    button_edit_select_item.Enabled = false;
    button_delete_select_item.Enabled = false;
    item_search_textBox.ReadOnly = true;
    button_search_item_table.Enabled = false;
    button_clear_search_item_table.Enabled = false;
    if(label_item_table.Text != ""){
      item_table.Enabled = false;
    }
    label_category_action_name.Text = "Edit category name, enter a new name.";
    textBox_add_category_name.Text = label_item_table.Text;
  }

  private void button_add_category_Click(object sender, EventArgs e){
    change_category_status = "add";
    textBox_add_category_name.ReadOnly = false;
    button_save_add_category.Enabled = true;
    button_cancel_add_category.Enabled = true;
    button_add_category.Enabled = false;
    button_edit_category.Enabled = false;
    button_delete_select_category.Enabled = false;
    category_search_textBox.ReadOnly = true;
    button_search_category_table.Enabled = false;
    button_clear_search_category_table.Enabled = false;
    category_table.Enabled = false;
    button_add_item.Enabled = false;
    button_edit_select_item.Enabled = false;
    button_delete_select_item.Enabled = false;
    item_search_textBox.ReadOnly = true;
    button_search_item_table.Enabled = false;
    button_clear_search_item_table.Enabled = false;
    if(label_item_table.Text != ""){
      item_table.Enabled = false;
    }
    label_category_action_name.Text = "Adding a new category, enter a name.";

  }

  private void button_save_add_category_Click(object sender, EventArgs e){
    if(change_category_status == "add"){
      try{
        if(!File.Exists(@"ims-data\" + textBox_add_category_name.Text.ToString() + ".imsdata")){
          File.Create(@"ims-data\" + textBox_add_category_name.Text.ToString() + ".imsdata").Dispose();
          MessageBox.Show("Category created successfully.");
          label_category_action_name.Text = "";
          textBox_add_category_name.Text = "";
          textBox_add_category_name.ReadOnly = true;
          button_save_add_category.Enabled = false;
          button_cancel_add_category.Enabled = false;
          category_search = "";
          category_search_textBox.Text = category_search;
          button_add_category.Enabled = true;
          category_table.Enabled = true;
          if(label_item_table.Text != ""){
            button_edit_category.Enabled = true;
            button_delete_select_category.Enabled = true;
            item_table.Enabled = true;
            button_add_item.Enabled = true;
            button_edit_select_item.Enabled = true;
            button_delete_select_item.Enabled = true;
            item_search_textBox.ReadOnly = false;
            button_search_item_table.Enabled = true;
            button_clear_search_item_table.Enabled = true;
          }else{
            button_edit_category.Enabled = false;
            button_delete_select_category.Enabled = false;
          }
          category_search_textBox.ReadOnly = false;
          button_search_category_table.Enabled = true;
          button_clear_search_category_table.Enabled = true;
          fill_table_of_file_list();
        }else{
          MessageBox.Show("There is already such a category.");
          fill_table_of_file_list();
        }
      }catch (System.Exception){
         MessageBox.Show("Not allowed category names.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    if(change_category_status == "edit"){
      try{
        if(!File.Exists(@"ims-data\" + textBox_add_category_name.Text.ToString() + ".imsdata")){
          System.IO.File.Move(@"ims-data\" + category_table.Rows[category_table.CurrentCell.RowIndex].Cells[2].Value.ToString(), @"ims-data\" + textBox_add_category_name.Text.ToString() + ".imsdata");
          MessageBox.Show("The renaming of the category was successful.");
          label_category_action_name.Text = "";
          textBox_add_category_name.Text = "";
          textBox_add_category_name.ReadOnly = true;
          button_save_add_category.Enabled = false;
          button_cancel_add_category.Enabled = false;
          category_search = "";
          category_search_textBox.Text = category_search;
          button_add_category.Enabled = true;
          category_table.Enabled = true;
          if(label_item_table.Text != ""){
            button_edit_category.Enabled = true;
            button_delete_select_category.Enabled = true;
            item_table.Enabled = true;
            button_add_item.Enabled = true;
            button_edit_select_item.Enabled = true;
            button_delete_select_item.Enabled = true;
            item_search_textBox.ReadOnly = false;
            button_search_item_table.Enabled = true;
            button_clear_search_item_table.Enabled = true;
          }else{
            button_edit_category.Enabled = false;
            button_delete_select_category.Enabled = false;
          }
          category_search_textBox.ReadOnly = false;
          button_search_category_table.Enabled = true;
          button_clear_search_category_table.Enabled = true;
          fill_table_of_file_list();
          category_search = "";
          category_search_textBox.Text = category_search;
          label_item_table.Text = "";
          item_table.Rows.Clear();
          item_table.Enabled = false;
          clear_editing_item_textBox();
          button_add_item.Enabled = false;
          button_edit_select_item.Enabled = false;
          button_delete_select_item.Enabled = false;
          item_search_textBox.ReadOnly = true;
          button_search_item_table.Enabled = false;
          button_clear_search_item_table.Enabled = false;
          button_edit_category.Enabled = false;
          button_delete_select_category.Enabled = false;
        }else{
          MessageBox.Show("There is already such a category.");
        }
      }catch (System.Exception){
         MessageBox.Show("Not allowed category names.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
  }

  private void button_cancel_add_category_Click(object sender, EventArgs e){
    category_table.Enabled = true;
    label_category_action_name.Text = "";
    textBox_add_category_name.Text = "";
    textBox_add_category_name.ReadOnly = true;
    button_add_category.Enabled = true;
    button_save_add_category.Enabled = false;
    button_cancel_add_category.Enabled = false;
    category_search_textBox.ReadOnly = false;
    button_search_category_table.Enabled = true;
    button_clear_search_category_table.Enabled = true;
    if(label_item_table.Text != ""){
      button_edit_category.Enabled = true;
      button_delete_select_category.Enabled = true;
      item_table.Enabled = true;
      button_add_item.Enabled = true;
      button_edit_select_item.Enabled = true;
      button_delete_select_item.Enabled = true;
      item_search_textBox.ReadOnly = false;
      button_search_item_table.Enabled = true;
      button_clear_search_item_table.Enabled = true;
    }else{
      button_edit_category.Enabled = false;
      button_delete_select_category.Enabled = false;
    }
  }

  // Item decription labels
  private void item_description_labels(){
    // Labels
    label_item_action_name.Size = new Size(300,20);
    label_item_action_name.Location = new Point(380,456);
    label_item_action_name.Text = "Item overview";
    label_item_action_name.Font = new Font("Arial", 10, FontStyle.Bold);
    main_panel.Controls.Add(label_item_action_name);
    label_item_ID.Size = new Size(70,20);
    label_item_ID.Location = new Point(380,480);
    label_item_ID.Text = "No";
    main_panel.Controls.Add(label_item_ID);
    label_item_Name.Size = new Size(70,20);
    label_item_Name.Location = new Point(380,504);
    label_item_Name.Text = "Name";
    main_panel.Controls.Add(label_item_Name);
    label_item_Producer.Size = new Size(70,20);
    label_item_Producer.Location = new Point(380,528);
    label_item_Producer.Text = "Producer";
    main_panel.Controls.Add(label_item_Producer);
    label_item_Serial_number.Size = new Size(70,20);
    label_item_Serial_number.Location = new Point(380,552);
    label_item_Serial_number.Text = "Serial no";
    main_panel.Controls.Add(label_item_Serial_number);
    label_item_Model_number.Size = new Size(70,20);
    label_item_Model_number.Location = new Point(380,576);
    label_item_Model_number.Text = "Model No";
    main_panel.Controls.Add(label_item_Model_number);
    label_item_Count.Size = new Size(70,20);
    label_item_Count.Location = new Point(380,600);
    label_item_Count.Text = "Quantity";
    main_panel.Controls.Add(label_item_Count);
    label_item_Dimensions.Size = new Size(70,20);
    label_item_Dimensions.Location = new Point(380,624);
    label_item_Dimensions.Text = "Dimensions";
    main_panel.Controls.Add(label_item_Dimensions);
    label_item_Weight.Size = new Size(70,20);
    label_item_Weight.Location = new Point(380,650);
    label_item_Weight.Text = "Weight";
    main_panel.Controls.Add(label_item_Weight);
    label_item_Description.Size = new Size(80,20);
    label_item_Description.Location = new Point(780,456);
    label_item_Description.Text = "Description";
    main_panel.Controls.Add(label_item_Description);
    // TextBox
    textBox_item_ID.Size = new Size(300,24);
    textBox_item_ID.Location = new Point(450,478);
    textBox_item_ID.Text = "";
    textBox_item_ID.ReadOnly = true;
    main_panel.Controls.Add(textBox_item_ID);
    textBox_item_Name.Size = new Size(300,24);
    textBox_item_Name.Location = new Point(450,502);
    textBox_item_Name.Text = "";
    textBox_item_Name.ReadOnly = true;
    main_panel.Controls.Add(textBox_item_Name);
    textBox_item_Producer.Size = new Size(300,24);
    textBox_item_Producer.Location = new Point(450,526);
    textBox_item_Producer.Text = "";
    textBox_item_Producer.ReadOnly = true;
    main_panel.Controls.Add(textBox_item_Producer);
    textBox_item_Serial_number.Size = new Size(300,24);
    textBox_item_Serial_number.Location = new Point(450,550);
    textBox_item_Serial_number.Text = "";
    textBox_item_Serial_number.ReadOnly = true;
    main_panel.Controls.Add(textBox_item_Serial_number);
    textBox_item_Model_number.Size = new Size(300,24);
    textBox_item_Model_number.Location = new Point(450,574);
    textBox_item_Model_number.Text = "";
    textBox_item_Model_number.ReadOnly = true;
    main_panel.Controls.Add(textBox_item_Model_number);
    textBox_item_Count.Size = new Size(300,24);
    textBox_item_Count.Location = new Point(450,598);
    textBox_item_Count.Text = "";
    textBox_item_Count.ReadOnly = true;
    main_panel.Controls.Add(textBox_item_Count);
    textBox_item_Dimensions.Size = new Size(300,24);
    textBox_item_Dimensions.Location = new Point(450,622);
    textBox_item_Dimensions.Text = "";
    textBox_item_Dimensions.ReadOnly = true;
    main_panel.Controls.Add(textBox_item_Dimensions);
    textBox_item_Weight.Size = new Size(300,24);
    textBox_item_Weight.Location = new Point(450,648);
    textBox_item_Weight.Text = "";
    textBox_item_Weight.ReadOnly = true;
    main_panel.Controls.Add(textBox_item_Weight);
    textBox_item_Description.Size = new Size(350,200);
    textBox_item_Description.Location = new Point(779,478);
    textBox_item_Description.Text = "";
    textBox_item_Description.ReadOnly = true;
    textBox_item_Description.Multiline = true;
    textBox_item_Description.ScrollBars = ScrollBars.Vertical;
    textBox_item_Description.WordWrap = true;
    main_panel.Controls.Add(textBox_item_Description);
  }

  // Main function
  static void Main(){
    Application.EnableVisualStyles();
    Application.Run(new Form1());
  }

}
