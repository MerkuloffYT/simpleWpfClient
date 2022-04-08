using System;
using System.Collections.Generic;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Music> GetMusics()
        {
            List<Music> musics = new List<Music>();
            Music music;

            using (bd_musicEntities entities = new bd_musicEntities())
            {
                var musicList = entities.music_table;
                foreach (var musicElement in musicList)
                {
                    music = new Music();
                    music.ID = (int)musicElement.Год;
                    music.AUTHOR = musicElement.Исполнитель;
                    music.NAME = musicElement.Наименование_трека;
                    music.ALBOM = musicElement.Альбом;
                    music.YEAR = (int)musicElement.Год;

                    musics.Add(music);
                }
            }
            return musics;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
