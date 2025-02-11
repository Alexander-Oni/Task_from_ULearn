namespace Pluralize;

public static class PluralizeTask
{
    public static string PluralizeRubles(int count)
    {
        // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
        int lastNumber = count % 10;
        int lastTwoNumber = count % 100;

        if (lastNumber == 1 && lastTwoNumber != 11)
            return "рубль";
        else if ((lastNumber == 2 || lastNumber == 3 || lastNumber == 4) &&
                (lastTwoNumber != 12 && lastTwoNumber != 13 && lastTwoNumber != 14))
            return "рубля";
        else
            return "рублей";
    }
}