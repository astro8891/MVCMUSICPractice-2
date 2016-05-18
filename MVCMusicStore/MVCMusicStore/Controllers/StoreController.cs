using MVCMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {

        MusicStoreEntities storeDB = new MusicStoreEntities();

        // GET: Store
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            
            return View(genres);
        }
               
        // GET: /Store/Browse  
        public ActionResult Browse(string genre)
        {
            //include from Genres.Include(“Albums”) to indicate that we want related albums as well
            //The lambda is asking it to retrive Genre's and Albums where the Genre name == the genre we passed in
            if(genre == null)
            {
                genre = "pop";
            } 
            var genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);
            //"Albums" is a property of Genre

            return View(genreModel);
        }
               
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);
            return View(album);
        }

    }
}