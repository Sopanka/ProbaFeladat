using ProbaFeladat.ProbaFeladatDataSetTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProbaFeladat
{
    /// <summary>
    /// Személyek adatai kezelő osztály
    /// </summary>
    public partial class PersonsForm : Form
    {
        /// <summary>
        /// Milyen módban van a rendszer
        /// </summary>
        private enum Mode
        {
            None = -1,
            New = 0,
            Edit = 1,
            Delete = 2
        }

        /// <summary>
        /// DataGridView cellában melyik adatbázis mező jelenik meg
        /// </summary>
        private enum CellField
        {
            None = -1,
            Azonosito = 0,
            Adoazonositojel = 1,
            TeljesNev = 2,
            Belepes = 3,
            Kilepes = 4,
            EmailCim = 5,
            Nem = 6
        }
        private Mode UserMode = Mode.None;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PersonsForm()
        {
            InitializeComponent();
            EnableButtons( true );
        }

        /// <summary>
        /// Táblák betöltése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonsForm_Load( object sender, EventArgs e )
        {
            genderTableAdapter.Fill( probaFeladatDataSet.gender );
            personsTableAdapter.Fill( probaFeladatDataSet.persons );
            SetInsertUpdateDeleteCommands();
        }

        /// <summary>
        /// Insert, Update, Delete SQL utasítások és paramétereik beállítása
        /// </summary>
        private void SetInsertUpdateDeleteCommands()
        {
            string insertQuery = "INSERT INTO dbo.persons (ADOAZONOSITOJEL, TELJESNEV, BELEPES, KILEPES, EMAILCIM, NEM) VALUES (@adoazonositojel, @teljesnev, @belepes, @kilepes, @emailcim, @nem)";
            personsTableAdapter.Adapter.InsertCommand = new SqlCommand( insertQuery );
            personsTableAdapter.Adapter.InsertCommand.Parameters.Add( new SqlParameter("@adoazonositojel", SqlDbType.Int, 16, "Adoazonositojel") );
            personsTableAdapter.Adapter.InsertCommand.Parameters.Add( new SqlParameter("@teljesnev", SqlDbType.VarChar, 50, "TeljesNev") );
            personsTableAdapter.Adapter.InsertCommand.Parameters.Add( new SqlParameter("@belepes", SqlDbType.Date, 20, "Belepes") );
            personsTableAdapter.Adapter.InsertCommand.Parameters.Add( new SqlParameter("@kilepes", SqlDbType.Date, 20, "Kilepes") );
            personsTableAdapter.Adapter.InsertCommand.Parameters.Add( new SqlParameter("@emailcim", SqlDbType.VarChar, 100, "EmailCim") );
            personsTableAdapter.Adapter.InsertCommand.Parameters.Add( new SqlParameter("@nem", SqlDbType.Int, 16, "Nem") );

            string updateQuery = "UPDATE dbo.persons SET ADOAZONOSITOJEL = @adoazonositojel, TELJESNEV = @teljesnev, BELEPES = @belepes, KILEPES = @kilepes, EMAILCIM = @emailcim, NEM = @nem WHERE AZONOSITO = @azonosito";
            personsTableAdapter.Adapter.UpdateCommand = new SqlCommand( updateQuery );
            personsTableAdapter.Adapter.UpdateCommand.Parameters.Add( new SqlParameter("@azonosito", SqlDbType.Int, 16, "Azonosito") );
            personsTableAdapter.Adapter.UpdateCommand.Parameters.Add( new SqlParameter("@adoazonositojel", SqlDbType.Int, 16, "Adoazonositojel") );
            personsTableAdapter.Adapter.UpdateCommand.Parameters.Add( new SqlParameter("@teljesnev", SqlDbType.VarChar, 50, "TeljesNev") );
            personsTableAdapter.Adapter.UpdateCommand.Parameters.Add( new SqlParameter("@belepes", SqlDbType.Date, 20, "Belepes") );
            personsTableAdapter.Adapter.UpdateCommand.Parameters.Add( new SqlParameter("@kilepes", SqlDbType.Date, 20, "Kilepes") );
            personsTableAdapter.Adapter.UpdateCommand.Parameters.Add( new SqlParameter("@emailcim", SqlDbType.VarChar, 100, "EmailCim") );
            personsTableAdapter.Adapter.UpdateCommand.Parameters.Add( new SqlParameter("@nem", SqlDbType.Int, 16, "Nem") );

            string deleteQuery = "DELETE FROM dbo.persons WHERE AZONOSITO = @azonosito";
            personsTableAdapter.Adapter.DeleteCommand = new SqlCommand( deleteQuery );
            personsTableAdapter.Adapter.DeleteCommand.Parameters.Add( new SqlParameter("@azonosito", SqlDbType.Int, 16, "Azonosito") );

            // Fentiek frissítése
            personsTableAdapter.Adapter.FillSchema( probaFeladatDataSet, SchemaType.Source );

            SqlConnection sqlConnection;
            string connetionString = @"Data Source=DESKTOP-IKOLLVV\SQLEXPRESS;Initial Catalog=ProbaFeladat;Integrated Security=True;Encrypt=False";
            sqlConnection = new SqlConnection( connetionString );
            personsTableAdapter.Connection = sqlConnection;
        }

        /// <summary>
        /// Adatmegjelenítő táblázat frissítése
        /// </summary>
        private void PersonsDataGridViewRefresh()
        {
            probaFeladatDataSet.persons.Clear();
            personsTableAdapter.Fill( probaFeladatDataSet.persons );
            PersonsDataGridView.Update();
            PersonsDataGridView.Refresh();
        }

        /// <summary>
        /// Új rekord felvitele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewButton_Click( object sender, EventArgs e )
        {
            EnableButtons( false );
            UserMode = Mode.New;
            personsBindingSource.AddNew();
        }

        /// <summary>
        /// Aktuális rekord módosítása
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click( object sender, EventArgs e )
        {
            EnableButtons( false );
            UserMode = Mode.Edit;
        }

        /// <summary>
        /// Aktuális rekord törlése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click( object sender, EventArgs e )
        {
            UserMode = Mode.Delete;
            DialogResult dialogResult = MessageBox.Show( "Biztosan törli ezt az adatsort?", "Törlés", MessageBoxButtons.YesNo );
            if ( dialogResult == DialogResult.Yes )
            {
                PersonsDataGridView.Rows.RemoveAt( PersonsDataGridView.CurrentRow.Index );
                personsTableAdapter.Adapter.Update( probaFeladatDataSet );

            }
            else if ( dialogResult == DialogResult.No )
            { // ebben az esetben nincs további teendő
            }
        }
        
        /// <summary>
        /// Módosítások mentése adatbázisba, szükség eetén adatmegjelenítés frissítése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click( object sender, EventArgs e )
        {
            try
            {
                if ( FerfiRadioButton.Checked )
                {
                    NemTextBox.Text = (string)FerfiRadioButton.Tag;
                }
                else if ( NoRadioButton.Checked )
                {
                    NemTextBox.Text = (string)NoRadioButton.Tag;
                }

                Validate();
                personsBindingSource.EndEdit();
                personsTableAdapter.Adapter.Update( probaFeladatDataSet );
                PersonsDataGridViewRefresh();
                EnableButtons( true );
                UserMode = Mode.None;
            }
            catch( Exception exception )
            {
                MessageBox.Show( exception.Message );
            }
            finally
            {

            }
        }

        /// <summary>
        /// Módosítás visszavonása
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click( object sender, EventArgs e )
        {
            EnableButtons( true );
            UserMode = Mode.None;
            personsBindingSource.CancelEdit();
        }

        /// <summary>
        /// Módosítás, Mentés és Visszavonás gombok engedélyezése / tiltása
        /// </summary>
        /// <param name="enable"></param>
        private void EnableButtons( bool enable )
        {
            ButtonPanel.Enabled = enable;
            ModositasGroupBox.Enabled = !enable;
        }

        /// <summary>
        /// Adatmegjelenítő táblázatban aktuális rekord váltás történt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonsDataGridView_SelectionChanged( object sender, EventArgs e )
        {
            if ( UserMode == Mode.New )
            {
                InDateTimePicker.Value = DateTime.Now;
                OutDateTimePicker.Value = InDateTimePicker.Value;
                OutDateTimePicker.Checked = false;

                return;
            }

            if ( PersonsDataGridView.CurrentRow != null )
            {
                if ( (string)PersonsDataGridView.CurrentRow.Cells[(int)CellField.Nem].Value == "férfi" )
                { // Nem radiobutton beállítása
                    FerfiRadioButton.Checked = true;
                }
                else
                {
                    NoRadioButton.Checked = true;
                }

                if ( PersonsDataGridView.CurrentRow.Cells[(int)CellField.Kilepes].FormattedValue == "" )
                { // Kilépés dátuma lehet üres
                    OutDateTimePicker.Value = InDateTimePicker.Value;
                    OutDateTimePicker.Checked = false;
                }
                else
                { // Amennyiben nem üres
                    DateTime outDate;
                    DateTime.TryParse((string)PersonsDataGridView.CurrentRow.Cells[(int)CellField.Kilepes].FormattedValue, out outDate);
                    OutDateTimePicker.Value = outDate;
                    OutDateTimePicker.Checked = true;
                }
            }
        }
    }
}
