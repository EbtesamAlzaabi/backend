using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        // تعريف القائمة الأصلية
        BindingList<Student> studentsList = new BindingList<Student>();

        public Form1()
        {
            InitializeComponent();
            dgvStudents.DataSource = studentsList;
            SetupGridView();

            // بيانات تجريبية
            studentsList.Add(new Student(1, "Widaad", "Engineering"));
            studentsList.Add(new Student(2, "Ebtisaam", "Information Technology"));
            studentsList.Add(new Student(2, "Malak", "Engineering "));
            studentsList.Add(new Student(2, "Fathia", "HR "));
        }

        private void SetupGridView()
        {
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Please enter both Name and Student ID");
                    return;
                }

                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string major = txtMajor.Text;

                studentsList.Add(new Student(id, name, major));
                ClearFields();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtMajor.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                var selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;
                studentsList.Remove(selectedStudent);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = studentsList;
            txtSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string keyword = txtSearchBox.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Please enter a name to search.");
                    return;
                }

                // 2. البحث في القائمة الأصلية
                var filteredList = studentsList
                    .Where(s => s.Name != null && s.Name.ToLower().Contains(keyword))
                    .ToList();

                // 3. التحقق من النتائج وعرض رسالة "موجود"
                if (filteredList.Count > 0)
                {
                    // تحديث الجدول بالنتائج
                    dgvStudents.DataSource = new BindingList<Student>(filteredList);

                    // إظهار رسالة تأكيد الوجود كما طلبتِ
                    MessageBox.Show($"Success! '{keyword}' is found.", "Search Result",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This student is not in the list.", "Not Found",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // إعادة عرض كل الطلاب
                    dgvStudents.DataSource = studentsList;
                }
            }
            catch (Exception ex)
            {
                // في حال حدوث خطأ مفاجئ، سيعطيكِ البرنامج سببه بدلاً من الخروج
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

       
    }
}
    
