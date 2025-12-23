using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class MovieTicket : UserControl
    {
        private Ticket ticket = null;
        public MovieTicket()
        {
            InitializeComponent();
        }

        public MovieTicket(Ticket ticket)
        {
            InitializeComponent();
            if (ticket != null)
            {
                ShowTime show = ShowTimeDAO.Instance.GetShowTime(ticket.IdMovie, ticket.Start_time);
                if (show != null)
                {
                    DTO.Screen screen = ScreenDAO.Instance.GetScreen(show.IDScreen);
                    if (screen != null)
                    {
                        DTO.Hall hall = HallDAO.Instance.GetHall(screen.IdHall);
                        if (hall != null)
                        {
                            CinemaLabel.Text = hall.Name;
                            CinemaAddressLabel.Text = hall.Location;
                        }
                    }
                }    
                DateLabel.Text = ticket.Purchase_date.ToString("dd-MM-yyyy hh:mm:ss tt");
                Staff staff = StaffDAO.Instance.GetStaff(ticket.IdStaff);
                if (staff != null)
                {
                    StaffNameLabel.Text = "Staff: " + staff.Name;
                }
                Movie movie = MovieDAO.Instance.GetMovieFromIDMovie(ticket.IdMovie);
                if (movie != null)
                {
                    MovieNameLabel.Text = movie.Title;
                    DurationLabel.Text = "Duration: " + movie.Duration.ToString() + " minutes";
                }
                StartTimeLabel.Text = "Start Time: " + ticket.Start_time.ToString("hh:mm:ss tt");
                Seat seat = SeatDAO.Instance.GetSeatInfoFromSeatID(ticket.IdSeat);
                if (seat != null)
                {
                    SeatTypeLabel.Text = "Seat Type: " + seat.SeatType.ToString();
                    SeatNumberLabel.Text = "Seat Number: " + seat.SeatRow.ToString() + seat.SeatNumber.ToString(); 
                }
                BillInfo info = BillInfoDAO.Instance.GetBillInfoTicket(ticket.IdBill);
                if (info != null)
                {
                    PriceLabel.Text = info.Price.ToString("c");
                    DiscountLabel.Text = info.Discount.ToString() + "%";
                    float price = info.Price * (100 - info.Discount) / 100;
                    PriceDiscountLabel.Text = price.ToString("c");
                }    
            }    

        }


    }
}
