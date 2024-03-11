using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TreeViewLab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadClients();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            treeView.Nodes.Clear();

            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT id, name, surname FROM Clients;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TreeNode treeNode = new TreeNode(reader["surname"].ToString() + " " + reader["name"].ToString());
                            treeNode.Tag = (int)reader["id"];
                            treeNode.ContextMenuStrip = cmsClient;
                            treeView.Nodes.Add(treeNode);
                            LoadCars(treeNode, (int)reader["id"]);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCars(TreeNode parent, int clientId)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT id, brand, model, license_plate FROM Cars WHERE client_id = @clientId;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@clientId", clientId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TreeNode treeNode = new TreeNode(reader["brand"].ToString() + " " + reader["model"].ToString() + " " + reader["license_plate"].ToString());
                            treeNode.Tag = (int)reader["id"];
                            treeNode.ContextMenuStrip = cmsCar;
                            parent.Nodes.Add(treeNode);
                            LoadOrders(treeNode, (int)reader["id"]);
                        }
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrders(TreeNode parent, int carId)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT id, order_date FROM Orders WHERE car_id = @carId;";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carId", carId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime date = (DateTime)reader["order_date"];
                            TreeNode treeNode = new TreeNode("Заказ от " + date.ToShortDateString());
                            treeNode.Tag = (int)reader["id"];
                            treeNode.ContextMenuStrip = cmsOrder;
                            parent.Nodes.Add(treeNode);
                        }
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void удалитьClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            int clientId = Convert.ToInt32(treeView.SelectedNode.Tag);

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить клиента? Будут удалены связанные с ним автомобили и заказы.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"DELETE FROM Clients WHERE id = @id;";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", clientId);

                        command.ExecuteNonQuery();

                        treeView.Nodes.Remove(treeView.SelectedNode);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();

            if (addClientForm.ShowDialog() == DialogResult.OK)
            {
                string surname = addClientForm.ClientSurname;
                string name = addClientForm.ClientName;

                var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"INSERT INTO Clients VALUES  (0, @surname, @name); SELECT LAST_INSERT_ID();";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@name", name);

                        int clientId = Convert.ToInt32(command.ExecuteScalar());

                        TreeNode treeNode = new TreeNode(surname + " " + name);
                        treeNode.Tag = clientId;
                        treeNode.ContextMenuStrip = cmsClient;
                        treeView.Nodes.Add(treeNode);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void изменитьClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClientForm editClientForm = new EditClientForm();

            TreeNode treeNode = treeView.SelectedNode;

            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT name, surname FROM Clients WHERE id = @id;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", Convert.ToInt32(treeNode.Tag));

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        editClientForm.ClientName = reader["name"].ToString();
                        editClientForm.ClientSurname = reader["surname"].ToString();
                    }

                    if (editClientForm.ShowDialog() == DialogResult.OK)
                    {
                        string surname = editClientForm.ClientSurname;
                        string name = editClientForm.ClientName;

                        string queryUpdate = @"UPDATE Clients SET name = @name, surname = @surname
                                               WHERE id = @id;";

                        MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);
                        commandUpdate.Parameters.AddWithValue("@surname", surname);
                        commandUpdate.Parameters.AddWithValue("@name", name);
                        commandUpdate.Parameters.AddWithValue("@id", Convert.ToInt32(treeNode.Tag));

                        commandUpdate.ExecuteNonQuery();

                        treeNode.Text = surname + " " + name;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode clickedNode = treeView.GetNodeAt(e.Location);

                if (clickedNode != null)
                {
                    treeView.SelectedNode = clickedNode;
                }
            }
        }

        private void удалитьCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            int carId = Convert.ToInt32(treeView.SelectedNode.Tag);

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить автомобиль? Будут удалены связанные с ним заказы.", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"DELETE FROM Cars WHERE id = @id;";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", carId);

                        command.ExecuteNonQuery();

                        treeView.Nodes.Remove(treeView.SelectedNode);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void изменитьCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCarForm editCarForm = new EditCarForm();

            TreeNode treeNode = treeView.SelectedNode;

            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT brand, model, license_plate FROM Cars WHERE id = @id;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", Convert.ToInt32(treeNode.Tag));

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        editCarForm.CarBrand = reader["brand"].ToString();
                        editCarForm.CarModel = reader["model"].ToString();
                        editCarForm.CarPlate = reader["license_plate"].ToString();
                    }

                    if (editCarForm.ShowDialog() == DialogResult.OK)
                    {
                        string brand = editCarForm.CarBrand;
                        string model = editCarForm.CarModel;
                        string plate = editCarForm.CarPlate;

                        string queryUpdate = @"UPDATE Cars SET brand = @brand, model = @model, license_plate = @license_plate
                                               WHERE id = @id;";

                        MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);
                        commandUpdate.Parameters.AddWithValue("@brand", brand);
                        commandUpdate.Parameters.AddWithValue("@model", model);
                        commandUpdate.Parameters.AddWithValue("@license_plate", plate);
                        commandUpdate.Parameters.AddWithValue("@id", Convert.ToInt32(treeNode.Tag));

                        commandUpdate.ExecuteNonQuery();

                        treeNode.Text = brand + " " + model + " " + plate;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();

            if (addCarForm.ShowDialog() == DialogResult.OK)
            {
                string brand = addCarForm.CarBrand;
                string model = addCarForm.CarModel;
                string plate = addCarForm.CarPlate;
                int clientId = Convert.ToInt32(treeView.SelectedNode.Tag);
                TreeNode treeNode = treeView.SelectedNode;

                var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"INSERT INTO Cars VALUES  (0, @clientId, @brand, @model, @license_plate); SELECT LAST_INSERT_ID();";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@brand", brand);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@license_plate", plate);
                        command.Parameters.AddWithValue("@clientId", clientId);

                        int carId = Convert.ToInt32(command.ExecuteScalar());
                        TreeNode newNode = new TreeNode(brand + " " + model + " " + plate);
                        newNode.Tag = carId;
                        newNode.ContextMenuStrip = cmsCar;
                        treeNode.Nodes.Add(newNode);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void добавитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();

            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                DateTime date = addOrderForm.OrderDate;
                int carId = Convert.ToInt32(treeView.SelectedNode.Tag);
                TreeNode treeNode = treeView.SelectedNode;

                var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"INSERT INTO Orders VALUES (0, @carId, @date); SELECT LAST_INSERT_ID();";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@carId", carId);
                        command.Parameters.AddWithValue("@date", date);

                        int orderId = Convert.ToInt32(command.ExecuteScalar());
                        TreeNode newNode = new TreeNode("Заказ от " + date.ToShortDateString());
                        newNode.Tag = orderId;
                        newNode.ContextMenuStrip = cmsOrder;
                        treeNode.Nodes.Add(newNode);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void изменитьOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrderForm editOrderForm = new EditOrderForm();

            TreeNode treeNode = treeView.SelectedNode;

            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT order_date FROM Orders WHERE id = @id;";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@id", Convert.ToInt32(treeNode.Tag));

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        editOrderForm.OrderDate = (DateTime)reader["order_date"];
                    }

                    if (editOrderForm.ShowDialog() == DialogResult.OK)
                    {
                        DateTime date = editOrderForm.OrderDate;

                        string queryUpdate = @"UPDATE Orders SET order_date = @date
                                               WHERE id = @id;";

                        MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);
                        commandUpdate.Parameters.AddWithValue("@date", date);
                        commandUpdate.Parameters.AddWithValue("@id", Convert.ToInt32(treeNode.Tag));

                        commandUpdate.ExecuteNonQuery();

                        treeNode.Text = "Заказ от " + date.ToShortDateString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void удалитьOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            int orderId = Convert.ToInt32(treeView.SelectedNode.Tag);

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить заказ?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"DELETE FROM Orders WHERE id = @id;";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", orderId);

                        command.ExecuteNonQuery();

                        treeView.Nodes.Remove(treeView.SelectedNode);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при работе с базой данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла неопознанная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            treeView.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeView_DragDrop(object sender, DragEventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["TreeView"].ConnectionString;

            TreeNode targetNode = treeView.GetNodeAt(treeView.PointToClient(new Point(e.X, e.Y)));

            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            if (targetNode != null && draggedNode != null)
            {
                // Перемещение заказа между машинами
                if (draggedNode.Level == 2 && targetNode.Level == 1)
                {
                    int orderId = Convert.ToInt32(draggedNode.Tag);
                    int carId = Convert.ToInt32(targetNode.Tag);

                    string updateOrderQuery = "UPDATE Orders SET car_id = @carId WHERE id = @orderId";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(updateOrderQuery, connection);
                        command.Parameters.AddWithValue("@carId", carId);
                        command.Parameters.AddWithValue("@orderId", orderId);
                        command.ExecuteNonQuery();
                    }
                }
                // Перемещение машины между клиентами
                else if (draggedNode.Level == 1 && targetNode.Level == 0)
                {
                    int carId = Convert.ToInt32(draggedNode.Tag);
                    int clientId = Convert.ToInt32(targetNode.Tag);

                    string updateCarQuery = "UPDATE Cars SET client_id = @clientId WHERE id = @carId";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(updateCarQuery, connection);
                        command.Parameters.AddWithValue("@clientId", clientId);
                        command.Parameters.AddWithValue("@carId", carId);
                        command.ExecuteNonQuery();
                    }
                }

                draggedNode.Remove();
                targetNode.Nodes.Add(draggedNode);
            }
        }
    }
}