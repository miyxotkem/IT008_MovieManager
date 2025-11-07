using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.DTO
{
    public class Movie
    {
        private int iD;
        private string title;
        private string genre;
        private string rated;
        private string release_date;
        private string director;
        private string language;
        private int duration;
        private string format;
        private string trailer;
        private string actor;
        private string brief;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Rated
        {
            get { return rated; }
            set { rated = value; }
        }

        public string Release_date
        {
            get { return release_date; }
            set { release_date = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string Format
        {
            get { return format; }
            set { format = value; }
        }

        public string Trailer
        {
            get { return trailer; }
            set { trailer = value; }
        }

        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }

        public string Brief
        {
            get { return brief; }
            set { brief = value; }
        }

        public Movie(int id, string title, string gerne, string rated, string release_date, string director, string language, int duration, string format, string trailer, string actor, string brief)
        {
            this.ID = id;
            this.Title = title;
            this.Genre = gerne;
            this.Rated = rated;
            this.Release_date = release_date;
            this.Director = director;
            this.Language = language;
            this.Duration = duration;
            this.Format = format;
            this.Trailer = trailer;
            this.Actor = actor;
            this.Brief = brief;
        }

        public Movie(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Title = row["Title"].ToString();
            this.Genre = row["Genre"].ToString();
            this.Rated = row["Rated"].ToString();
            this.Release_date = row["Release_date"].ToString();
            this.Director = row["Director"].ToString();
            this.Language = row["Language"].ToString();
            this.Duration = (int)row["Duration"];
            this.Format = row["Format"].ToString();
            this.Trailer = row["Trailer"].ToString();
            this.Actor = row["Actor"].ToString();
            this.Brief = row["Brief"].ToString();
        }
    }
}
