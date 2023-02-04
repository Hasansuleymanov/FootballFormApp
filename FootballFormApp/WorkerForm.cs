using FootballFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballFormApp
{
    public partial class WorkerForm : Form
    {
        FootballContext fc=new FootballContext();
        public WorkerForm()
        {
            InitializeComponent();
        }

        public void FillStadium()
        {
            cmbStadium.Items.AddRange(fc.Stadiums.Select(s=>s.Name).ToArray());
        }
        public void FillSchedule()
        {
            cmbTime.Items.AddRange(fc.Schedules.Select(s=>s.MatchDate).ToArray());
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            FillStadium();
            FillSchedule();
        }
        public int GetStadiumIdForName(string name)
        {
            Stadium selectedStadium=fc.Stadiums.FirstOrDefault(s=>s.Name==name);
            return selectedStadium.Id;
        }
        public int GetScheduleIdForTime(string time)
        {
            Schedule selectedTime = fc.Schedules.FirstOrDefault(s => s.MatchDate == time);
            return selectedTime.Id;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int count = (int)nmCount.Value;
            string phone = txtPhone.Text;
            string time = cmbTime.Text;
            string stadium = cmbStadium.Text;
            int StadId = GetStadiumIdForName(stadium);
            int ScheduleId = GetScheduleIdForTime(time);
            List<ReserveToClient> reserveToClients = new();
            List<ReserveToRoom> reserveToRoom = new();
            List<ReserveToSchedule>reserveToSchedule = new();
            List<ReserveToStadium>reserveToStadium = new();
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(phone))
            {
                Client client = new Client()
                {
                    Count = count,
                    Name = name,
                    Surname = surname,
                    Telephone = phone,
                };
                reserveToClients.Add(new ReserveToClient()
                {
                    ReserveId=client.Id,
                });
                reserveToRoom.Add(new ReserveToRoom()
                {
                    ClientId=client.Id,
                    RoomId=client.Id
                });
                reserveToSchedule.Add(new ReserveToSchedule()
                {
                    ClientId = client.Id,
                    ScheduleId = ScheduleId
                });
                reserveToStadium.Add(new ReserveToStadium()
                {
                    ClientId = client.Id,
                    StadiumId = StadId
                });
                Reserve rs = new Reserve()
                {
                    ClientToRooms=reserveToRoom,
                    ClientToSchedules=reserveToSchedule,
                    ClientToStadiums=reserveToStadium,
                    ReserveToClients=reserveToClients,
                };
                lblPrice.Text = "50 Man";
                dtgMatches.ColumnCount = 8;
                dtgMatches.Columns[0].Name = "Id";
                dtgMatches.Columns[1].Name = "Name";
                dtgMatches.Columns[2].Name = "Surname";
                dtgMatches.Columns[3].Name = "Count";
                dtgMatches.Columns[4].Name = "Phone";
                dtgMatches.Columns[5].Name = "Stadium";
                dtgMatches.Columns[6].Name = "Time";
                dtgMatches.Columns[7].Name = "Room";
                dtgMatches.Rows.Add(client.Id,name, surname, count, phone, stadium, time,client.Id);
                fc.Clients.Add(client);
                fc.Reserves.Add(rs);
                fc.SaveChanges();
                MessageBox.Show("Rezerv ugurla yaradildi", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
