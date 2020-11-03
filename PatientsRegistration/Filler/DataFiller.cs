namespace PatientsRegistration.Service
{
    public static class DataFiller
    {
        public static void InitializeMonth(RecordContext db, int year, int month)
        {

            Record record;

            record = new Record(true, "Отделение", year, month,
                    "ГАСТРОЭНТЕРОЛОГИЧЕСКИЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. гастроэнтерологические", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "ГЕМАТОЛОГИЧЕСКИЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "КАРДИОЛОГИЧЕСКИЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. кардиологические", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. ревматологические", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "КАРДИОЛОГИЧЕСКОЕ 3", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. кардиологические", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "НЕВРОЛОГИЧЕСКИЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. неврологические", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();
          
            record = new Record(false, "Отделение", year, month,
                "в т.ч. Неврология №2 для больных ОМНК", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "НЕВРОЛОГИЯ №3", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. кардио", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. неврология", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "СОСУДИСТЫЕ (ОНМК центр)", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ПУЛЬМОНОЛОГИЧЕСКИЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. пульмонологические", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "НЕФРОЛОГИЧЕСКИЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. нефрологические", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ЭНДОТЕРАПЕВТИЧЕСКИЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. взрослые", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "НЕЙРОХИРУРГИЧЕСКИЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. взрослые", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. детские", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "НЕЙРОХИРУРГИЧЕСКИЕ 2", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ОТОЛАРИНГОЛОГИЧЕСКИЕ ВЗРОСЛЫЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. отоларингологические взрослые", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ОФТАЛЬМОЛОГИЧЕСКИЕ ВЗРОСЛЫЕ", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. офтальмологические взрослые", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Терапия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "СОСУДИСТОЙ ХИРУРГИИ", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. сосудистой", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. кардиохирургические", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ТОО", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. травматологические", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. ортопедические", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ТОРАКАЛЬНОЙ ХИРУРГИИ", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "УРОЛОГИЧЕСКИЕ", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. урологические", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ОГХ", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. огх", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ХИРУРГИЧЕСКОЕ №2", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. общая хирургия", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ЧЕРЕПНО-ЛИЦЕВАЯ ХИРУРГИЯ", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. взрослые", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. детские", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "платные", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "ТРАВМАТОЛОГИЧЕСКОЕ", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(true, "Отделение", year, month,
                "РХМДиЛ", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. сосуд", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "в т.ч. кардио", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "Дневной стационар МХГ", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "Дневной стационар Гематологическое", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "Дневной стационар Хирургическое", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Отделение", year, month,
                "Дневной стационар Гастроэнтерологическое", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Реанимация", year, month,
                "ОРиТ-1", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Реанимация", year, month,
                "ОРиТ-3", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Реанимация", year, month,
                "ОРиТ-4", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Реанимация", year, month,
                "ОРиТ-5", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Реанимация", year, month,
                "ОАиР-2", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();

            record = new Record(false, "Реанимация", year, month,
                "ОАиР-3", "Хирургия");
            db.Records.Add(record);
            db.SaveChanges();
        }
    }
}
