using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Albums_Base
{
    /// <summary>
    /// Класс артиста
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string NickName { get; private set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DOB { get; private set; }
        /// <summary>
        /// Список работ
        /// </summary>
        public List<About> About { get; private set; }
        /// <summary>
        /// Фото
        /// </summary>
        public byte[] Photo { get; private set; }
    }
    /// <summary>
    /// Класс альбома
    /// </summary>
    public class Album
    {
        /// <summary>
        /// Список жанров
        /// </summary>
        public static List<string> MusicGenres = new List<string>()
        {
            "Rock", "EDM", "Jazz", "Blues", "Rap", "R&B", "Pop",
            "Classical", "House", "Techno", "Metal", "Hip-Hop",
            "Synthwave", "Shanson", "Epic", "Commercial"
        };
        /// <summary>
        /// Список стран 
        /// </summary>
        public static List<string> MusicCountries = new List<string>()
        {

        };
        /// <summary>
        /// Название альбома
        /// </summary>
        public string AlbumName { get; private set; }
        /// <summary>
        /// Жанры альбома
        /// </summary>
        public List<string> AlbumGenres { get; private set; }
        /// <summary>
        /// Год выпуска
        /// </summary>
        public DateTime Year { get; private set; }
        /// <summary>
        /// Продолжительность
        /// </summary>
        public DateTime Duration { get; private set; }
        /// <summary>
        /// Цензура
        /// </summary>
        public string Censorship { get; set; }
        /// <summary>
        /// Продакшен
        /// </summary>
        public List<About> Credits { get; private set; }
        /// <summary>
        /// Обложка
        /// </summary>
        public byte[] Cover { get; private set; }

    }

    /// <summary>
    /// Сведения о альбоме
    /// </summary>
    public class About
    {
        /// <summary>
        /// Альбом
        /// </summary>
        public Album Album { get; private set; }
        /// <summary>
        /// Артист
        /// </summary>
        public Artist Artist { get; private set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; private set; }

    }

}


