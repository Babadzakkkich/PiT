# Описание практической работы №6
**Результат работы программы до процесса тестирования**
![ResFalse](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/ProgramResultFalse.png)

### Результаты данной ПР представлены в общей таблице 

| Действие | Изображение | Результат | Вывод |
|:----------:|:----------:|:----------:|:----------:|
| Создание метода для тестирования debit | ![Тут изображение медота в VS 1](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/DebitLessThanZero.png) ![2](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/DebitMoreThanBalance.png) ![3](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/DebitUpdatesBalance.png)| Был создан метод | Можно начинать тестирование |
| Тесты метода debit | ![Тут изображение тестов в VS](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/DebitTestBad.png) | Тесты показали отрицательный результат | Требуется рефакторинг медота debit |
| Регрессионное тестирование (после рефакторинга) | ![Тут изображение тестов в VS](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/DebitTestGood.png) | Тесты показали положительный результат | Рефакторинг произведён успешно |
| Создание метода для тестирования credit| ![Тут изображение медота в VS](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/CreditLessThanZero.png ) ![2](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/CreditUpdatesBalance.png)| Был создан метод | Можно начинать тестирование |
| Тесты метода credit | ![Тут изображение тестов в VS](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/CreditTestGood.png) | Тесты показали положительный результат | Рефакторинг не требуется |
| Тесты обоих методов | ![Тут изображение тестов в VS](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/TestAll.png) | Тесты показали положительный результат | Рефакторинг не требуется |

**После окончания этапа тестирования была ещё раз запущена программа**
![ResTrue](https://github.com/Babadzakkkich/PiT/blob/master/Kobzev_Busin/222_Kobzev_Busin_PR6_Bank/Images/ProgramResultTrue.png)
