using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataExtraction
{
    public partial class Form1 : Form
    {
        private DatabaseRepository databaseRepository = new DatabaseRepository();
        private string filePath = ".\\output.txt";
        private string textDefaultCombo = "-- SELECT --";
        private List<String> listaOpcoes = new List<string>()
        {
            "Contains",
            "Equals",
            "Not equal",
            "Bigger",
            "Bigger or equal",
            "Smaller",
            "Less or equal"
        };
        private List<String> listaAndOr = new List<string>()
        {
            "",
            "AND",
            "OR"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Logger.Log(Logger.LogType.INFO, "Form1 loaded.");
            this.ConfiguraFases(1);
        }

        private async void ConfiguraFases(int fase)
        {
            switch (fase)
            {
                case 1:
                    labelDirectory.Text = filePath;
                    comboBoxDataBaseName.Enabled = true;
                    comboBoxTableView.Enabled = false;
                    comboBoxAndOr.Enabled = false;
                    comboBoxColumns.Enabled = false;
                    comboBoxOptions.Enabled = false;
                    textBoxValueFilter.Enabled = false;
                    buttonAddFilter.Enabled = false;
                    buttonClearFilter.Enabled = false;
                    buttonViewData.Enabled = false;
                    buttonStart.Enabled = false;
                    dataGridView1.Enabled = false;

                    var dataTable = new DataTable();
                    dataTable.Columns.Add("TABLE_NAME", typeof(string));
                    this.ConfigComboBox(comboBoxTableView, dataTable, "TABLE_NAME");

                    comboBoxOptions.Items.Clear();
                    comboBoxOptions.Items.AddRange(listaOpcoes.ToArray());
                    comboBoxOptions.SelectedIndex = 0;

                    comboBoxAndOr.Items.Clear();
                    comboBoxAndOr.Items.AddRange(listaAndOr.ToArray());
                    comboBoxAndOr.SelectedIndex = 0;

                    var data = await databaseRepository.GetListAllDataBaseName();
                    this.ConfigComboBox(comboBoxDataBaseName, data, "name");

                    var dataTableColumns = new DataTable();
                    dataTableColumns.Columns.Add("COLUMN_NAME", typeof(string));
                    this.ConfigComboBox(comboBoxColumns, dataTableColumns, "COLUMN_NAME");

                    labelFilterValue.Text = string.Empty;
                    textBoxValueFilter.Text = string.Empty;
                    dataGridView1.DataSource = null;
                    break;

                case 2:
                    comboBoxTableView.Enabled = true;
                    break;

                case 3:
                    comboBoxAndOr.Enabled = true;
                    comboBoxColumns.Enabled = true;
                    comboBoxOptions.Enabled = true;
                    textBoxValueFilter.Enabled = true;
                    buttonAddFilter.Enabled = true;
                    buttonClearFilter.Enabled = true;
                    buttonViewData.Enabled = true;
                    dataGridView1.Enabled = true;
                    buttonStart.Enabled = true;
                    break;

                case 4:
                    comboBoxDataBaseName.Enabled = false;
                    comboBoxTableView.Enabled = false;
                    comboBoxAndOr.Enabled = false;
                    comboBoxColumns.Enabled = false;
                    comboBoxOptions.Enabled = false;
                    textBoxValueFilter.Enabled = false;
                    buttonAddFilter.Enabled = false;
                    buttonClearFilter.Enabled = false;
                    buttonViewData.Enabled = false;
                    dataGridView1.Enabled = false;
                    buttonStart.Enabled = false;
                    break;
            }
        }

        private void ConfigComboBox(ComboBox comboBox, DataTable data, string displayMember)
        {
            DataRow row = data.NewRow();
            row[displayMember] = textDefaultCombo;
            data.Rows.InsertAt(row, 0);

            comboBox.DataSource = data;
            comboBox.DisplayMember = displayMember;
            comboBox.SelectedIndex = 0;
        }

        private async void comboBoxDataBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDataBaseName.SelectedIndex > 0)
            {
                DataRowView selectedItem = (DataRowView)comboBoxDataBaseName.SelectedItem;
                string dataBaseName = (string)selectedItem["name"];
                Logger.Log(Logger.LogType.INFO, $"Selected database: {dataBaseName}");
                var data = await databaseRepository.GetListAllTableOrViewName(dataBaseName);
                this.ConfigComboBox(comboBoxTableView, data, "TABLE_NAME");

                ConfiguraFases(2);
            }
        }

        private async void comboBoxTableView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTableView.SelectedIndex > 0)
            {
                DataRowView selectedItemDatabase = (DataRowView)comboBoxDataBaseName.SelectedItem;
                string dataBaseName = (string)selectedItemDatabase["name"];

                DataRowView selectedItemTableOrView = (DataRowView)comboBoxTableView.SelectedItem;
                string tableOrViewName = (string)selectedItemTableOrView["TABLE_NAME"];

                Logger.Log(Logger.LogType.INFO, $"Selected table/view: {tableOrViewName} from database: {dataBaseName}");
                var data = await databaseRepository.GetListAllColumnsName(dataBaseName, tableOrViewName);
                this.ConfigComboBox(comboBoxColumns, data, "COLUMN_NAME");

                ConfiguraFases(3);
            }
        }

        private void buttonAddFilter_Click(object sender, EventArgs e)
        {
            string operation = "";

            switch (comboBoxOptions.SelectedItem.ToString().Trim())
            {
                case "Contains":
                    operation = "LIKE";
                    break;
                case "Equals":
                    operation = "=";
                    break;
                case "Not equal":
                    operation = "<>";
                    break;
                case "Bigger":
                    operation = ">";
                    break;
                case "Bigger or equal":
                    operation = ">=";
                    break;
                case "Smaller":
                    operation = "<";
                    break;
                case "Less or equal":
                    operation = "<=";
                    break;
            }

            string valueFilterOperation = operation.Equals("LIKE") ? $"'%{Helper.VerificaSeEData(textBoxValueFilter.Text.Trim())}%'" : $"'{Helper.VerificaSeEData(textBoxValueFilter.Text.Trim())}'";

            if (!string.IsNullOrEmpty(labelFilterValue.Text.Trim()) && string.IsNullOrEmpty(comboBoxAndOr.SelectedItem.ToString()))
            {
                labelFilterValue.Text = string.Empty;
            }

            DataRowView selectedItemBoxColumns = (DataRowView)comboBoxColumns.SelectedItem;
            string column = (string)selectedItemBoxColumns["COLUMN_NAME"];

            string valueFilter = $"{comboBoxAndOr.SelectedItem.ToString().Trim()} {column.ToString().Trim()} {operation} {valueFilterOperation} ";
            labelFilterValue.Text += valueFilter;
            Logger.Log(Logger.LogType.INFO, "Filter added: " + valueFilter);
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            labelFilterValue.Text = string.Empty;
        }

        private void buttonViewData_Click(object sender, EventArgs e)
        {
            if (comboBoxTableView.SelectedIndex > 0)
            {
                DataRowView selectedItemDatabase = (DataRowView)comboBoxDataBaseName.SelectedItem;
                string dataBaseName = (string)selectedItemDatabase["name"];

                DataRowView selectedItemTableOrView = (DataRowView)comboBoxTableView.SelectedItem;
                string tableOrViewName = (string)selectedItemTableOrView["TABLE_NAME"];

                string filter = labelFilterValue.Text.Trim();

                Logger.Log(Logger.LogType.INFO, $"View data requested for table/view: {tableOrViewName} from database: {dataBaseName}, with filter: {filter}");
                dataGridView1.DataSource = databaseRepository.ListAllData(dataBaseName, tableOrViewName, filter);        
            }
            else
            {
                MessageBox.Show("Selected a table or view to proceed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.ConfiguraFases(1);
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxTableView.SelectedIndex > 0)
            {
                ConfiguraFases(4);

                Logger.Log(Logger.LogType.INFO, "Starting the data export file generation");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    DataRowView selectedItemDatabase = (DataRowView)comboBoxDataBaseName.SelectedItem;
                    string dataBaseName = (string)selectedItemDatabase["name"];

                    DataRowView selectedItemTableOrView = (DataRowView)comboBoxTableView.SelectedItem;
                    string tableOrViewName = (string)selectedItemTableOrView["TABLE_NAME"];

                    var tableSchema = await databaseRepository.GetListAllColumnsName(dataBaseName, tableOrViewName);
                    List<string> columnNames = new List<string>();
                    foreach (DataRow row in tableSchema.Rows)
                    {
                        string columnName = row["COLUMN_NAME"].ToString();
                        columnNames.Add(columnName);
                    }

                    string header = string.Join(";", columnNames);
                    await writer.WriteLineAsync(header);

                    await Extract(writer);

                    ConfiguraFases(1);
                }

                Logger.Log(Logger.LogType.INFO, "Completed file generation");
            }
            else
            {
                MessageBox.Show("Selected a table or view to proceed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<string> FormatData(List<List<object>> rawData)
        {
            const int batchSize = 10000;
            var rows = new List<string>();
            var stringBuilder = new StringBuilder();

            foreach (var row in rawData)
            {
                for (int i = 0; i < row.Count; i++)
                {
                    string value = row[i]?.ToString() ?? "";

                    string remainingContent = value.Trim().Replace(";", "");
                    remainingContent = Regex.Replace(remainingContent, @"[\r\n\t]", " ");
                    stringBuilder.Append(remainingContent);

                    if (i < row.Count - 1)
                    {
                        stringBuilder.Append(";");
                    }
                }

                stringBuilder.Append(Environment.NewLine);

                if (stringBuilder.Length >= batchSize)
                {
                    rows.Add(stringBuilder.ToString());
                    stringBuilder.Clear();
                }
            }

            if (stringBuilder.Length > 0)
            {
                rows.Add(stringBuilder.ToString());
            }

            return rows;
        }

        private async Task Extract(StreamWriter writer)
        {
            DataRowView selectedItemDatabase = (DataRowView)comboBoxDataBaseName.SelectedItem;
            string dataBaseName = (string)selectedItemDatabase["name"];

            DataRowView selectedItemTableOrView = (DataRowView)comboBoxTableView.SelectedItem;
            string tableOrViewName = (string)selectedItemTableOrView["TABLE_NAME"];

            string filter = labelFilterValue.Text.Trim();

            var rawData = await databaseRepository.ListAllDataToWrite(dataBaseName, tableOrViewName, filter);
            var formattedData = FormatData(rawData);

            foreach (var row in formattedData)
            {
                await writer.WriteAsync(row);
            }
        }

        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivos de Texto|*.txt|Todos os arquivos|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.filePath = saveFileDialog.FileName;
                    labelDirectory.Text = this.filePath;
                }
            }
        }
    }
}
