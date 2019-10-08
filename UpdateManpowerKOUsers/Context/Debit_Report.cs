//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpdateManpowerKOUsers.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Debit_Report
    {
        public int ID_заказа { get; set; }
        public int C__заказа { get; set; }
        public string Авто_жд { get; set; }
        public string Заказчик_по_Project { get; set; }
        public string Юр__Лицо_заказчика { get; set; }
        public string C__контракта { get; set; }
        public Nullable<System.DateTime> Дата_контракта { get; set; }
        public string Номер_спецификации_приложения_отгрузочной_разнарядки { get; set; }
        public Nullable<System.DateTime> Дата_спецификации_приложения_отгрузочной_разнарядки { get; set; }
        public Nullable<int> Количество_дней_на_приёмку_по_договору { get; set; }
        public string Номер_пункта_договора_о_сроках_приёмки_с_момента_прибытия { get; set; }
        public string Грузополучатель { get; set; }
        public string Станция_назначения { get; set; }
        public string Менеджер { get; set; }
        public Nullable<double> Выручка__без_НДС__ТЭО___USD { get; set; }
        public string Условия_оплаты_по_договору_ { get; set; }
        public Nullable<int> Условия_оплаты_по_договору__дней_ { get; set; }
        public string Требования_к_упаковке_и_маркировке { get; set; }
        public System.DateTime Дата_открытия_заказа { get; set; }
        public Nullable<System.DateTime> Дата_отправки_уведомления_о_готовности_к_отгрузке { get; set; }
        public string Тип_согласования_отгрузки { get; set; }
        public Nullable<System.DateTime> Дата_согласования_отгрузки_с_Заказчиком { get; set; }
        public string Номер_ЖДН { get; set; }
        public Nullable<System.DateTime> Дата_отгрузки_ЖДН___штамп_ { get; set; }
        public Nullable<int> Вес__кг { get; set; }
        public Nullable<int> Количество_платформ { get; set; }
        public string Номера_платформ { get; set; }
        public string Номера_пломб { get; set; }
        public string Габариты { get; set; }
        public Nullable<double> Транспорт_Ист_порт_сервис__сумма___RUR { get; set; }
        public string Счет___транспорта__RUR { get; set; }
        public Nullable<double> НДС_с_суммы_транспорта__RUR { get; set; }
        public string Номер_ТН { get; set; }
        public Nullable<System.DateTime> Дата_ТН { get; set; }
        public string Номер_счёта_фактуры__Катэк_М { get; set; }
        public Nullable<System.DateTime> Дата_счёта_фактуры { get; set; }
        public Nullable<double> Сумма_отгрузки_в_контрактной_стоимости__RUR { get; set; }
        public Nullable<System.DateTime> Плановая_дата_прибытия_на_станцию_назначения { get; set; }
        public Nullable<System.DateTime> Дата_прибытия_заказа_на_станцию_назначения { get; set; }
        public string C__письма_о_прибытии_заказа_на_станцию_назначения { get; set; }
        public Nullable<System.DateTime> Дата_письма__уведомления_Заказчика_о_прибытии_ПЛАН { get; set; }
        public string Дата_письма__уведомления_Заказчика_о_прибытии_ФАКТ { get; set; }
        public string Дата_рекламации { get; set; }
        public string Наличие_незакрытой_рекламации { get; set; }
        public string Дата_закрытия_рекламации { get; set; }
        public Nullable<System.DateTime> Дата_оприходования { get; set; }
        public Nullable<System.DateTime> Расчётная_дата_оплаты { get; set; }
        public Nullable<System.DateTime> Дата_оплаты__по_сверке_с_покупателем_ { get; set; }
        public Nullable<System.DateTime> Дата_регистрации_заказа { get; set; }
        public Nullable<System.DateTime> Дата_внесения_ТЭО { get; set; }
        public Nullable<System.DateTime> Дата_внесения_прототипов { get; set; }
        public Nullable<System.DateTime> Дата_получения_договора { get; set; }
        public Nullable<System.DateTime> Дата_получения_вагонной_ведомости { get; set; }
        public Nullable<System.DateTime> Дата_отправки_письма_о_начале_производства { get; set; }
        public Nullable<System.DateTime> Дата_отправки_рассылки_об_отгрузке { get; set; }
        public Nullable<double> Сумма_оплаты__накопительно_ { get; set; }
        public Nullable<System.DateTime> Дата_факт_оплаты__последний_платёж_ { get; set; }
        public Nullable<double> Остаток_оплаты { get; set; }
        public Nullable<int> Количество_дней_с_момента_прибытия_на_станцию_назначения_до_момента_оприходования { get; set; }
        public Nullable<int> Количество_дней_с_момента_оприходования_до_оплаты { get; set; }
    }
}