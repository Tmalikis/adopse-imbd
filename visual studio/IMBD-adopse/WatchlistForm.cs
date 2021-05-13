﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using IMBD_adopse.classes;

namespace IMBD_adopse
{
    public partial class WatchlistForm : Form
    {
        private int userID;

        public WatchlistForm(int userid)
        {
            InitializeComponent();
            sendObjHome(userid);
        }

        
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public void sendObjHome(int id)
        {
            userID = id;
            loadWatchlist(id);
        }


        public void loadWatchlist(int uid)
        {
            try { 
           // Debug.WriteLine("test: " + uid);
            WishlistMovie wishlist = new WishlistMovie();
            List<WishlistMovie> obj = wishlist.get(uid);
            if(obj == null) { MessageBox.Show("Your watchlist is empty.", "Watchlist"); return; }
            // List<Movie> mov=null;
            Movie movie = new Movie();
            List<Movie> test;
            foreach (WishlistMovie wish in obj)
            {
               test = movie.getMovies(wish.Movie_id);
               WatchlistContainer container = new WatchlistContainer(test[0]) { TopLevel = false, TopMost = true };                               
               flowWatchlist.Controls.Add(container);
                    container.Show();
                    // Debug.WriteLine("\n ID: " + wish.Id + " Movie_ID: " + wish.Movie_id + " User_ID: " + wish.User_id);
                    //Debug.WriteLine(movie.getMovies(wish.Id));
                    
                    // Debug.WriteLine(test[0].Name);

                    /*PictureBox movieImage = new PictureBox();
                    movieImage.ImageLocation = test[0].Photo;
                    // movieImage.SizeMode = PictureBoxSizeMode.AutoSize;
                    movieImage.Size = new System.Drawing.Size(180, 210);
                    movieImage.SizeMode = PictureBoxSizeMode.CenterImage;
                    movieImage.SizeMode = PictureBoxSizeMode.StretchImage;

                        /*  movieImage.Click += (sender, e) =>
                          {
                              GlimpseForm glimpseForm = new GlimpseForm(null,test[0].Id);
                              glimpseForm.setUserId(userID);
                              glimpseForm.Show();
                          };
                        flowWatchlist.Controls.Add(movieImage); 
                        */
                }

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


        }



    }
}
