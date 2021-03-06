using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Music> GetMusics();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Добавьте здесь операции служб
    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Music
    {
        int id;
        string author;
        string name;
        string albom;
        int year;

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string AUTHOR
        {
            get { return author; }
            set { author = value; }
        }

        [DataMember]
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string ALBOM
        {
            get { return albom; }
            set { albom = value; }
        }

        [DataMember]
        public int YEAR
        {
            get { return year; }
            set { year = value; }
        }
    }
}
