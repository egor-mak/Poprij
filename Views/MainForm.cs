using Poprij.Models;
using Poprij.Views.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poprij.Utils;

namespace Poprij
{
    public partial class MainForm : Form
    {
        int currentPage = 0;
        int currentSize = 10;

        List<Agent> agents = new List<Agent>();
        public MainForm()
        {
            InitializeComponent();
            agents = DBContext.db.Agent.ToList();
            GenerateAgentCardList(agents);
        }
        private void GenerateAgentCardList(List<Agent> agent)
        {
            foreach (var a in agent)
            {
                AgentCard card = new AgentCard();
                card.GenerateDataToAgentCard(a);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void SortListView()
        {
            flowLayoutPanel1.Controls.Clear();
            var ListUpdate = DBContext.db.Agent.ToList();
            if (SortComboBox.Text == "Наименование")
            {
                if (!descCheckBox.Checked)
                {
                    ListUpdate = ListUpdate.OrderBy(a => a.Title).ToList();
                }
                else
                {
                    ListUpdate = ListUpdate.OrderByDescending(a => a.Title).ToList();
                }
            }
            if (SortComboBox.Text == "Приоритет агента")
            {
                if (!descCheckBox.Checked)
                {
                    ListUpdate = ListUpdate.OrderBy(a => a.Priority).ToList();
                }
                else
                {
                    ListUpdate = ListUpdate.OrderByDescending(a => a.Priority).ToList();

                }
            }
            if (FiltrComboBox.SelectedIndex >0)
            {
                ListUpdate = ListUpdate.Where(type => type.AgentType.Title == FiltrComboBox.SelectedItem.ToString()).ToList();
            }
            if (SearchTxtBox.Text != "Введите для поиска")
            {
                ListUpdate = ListUpdate.Where(p => p.Title.ToLower().Contains(SearchTxtBox.Text.ToLower())
                || p.Phone.Contains(SearchTxtBox.Text)
                || p.Email.Contains(SearchTxtBox.Text.ToLower())).ToList();
            }

            GenerateAgentCardList(ListUpdate);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var allType = DBContext.db.AgentType.Select(type => type.Title).ToList();
            allType.Insert(0, "Все типы");
            FiltrComboBox.DataSource = allType;
            FiltrComboBox.SelectedIndex = 0;
            SortComboBox.SelectedIndex = 0;
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void descCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void FiltrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            SortListView();
        }

        private void Paging(int pagenum, int pagesize)
        {
            if (currentPage < 0)
            {
                currentPage = 0;
                return;
            }
        }

    }
}
