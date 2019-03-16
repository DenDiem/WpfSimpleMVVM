# WpfSimpleMVVM
For NaUKMA C sharp homework 2 + 3
//TASK

//Task 2
Створіть клас, який називається Person. Додайте до класу Person наступні 
властивості:
Ім'я
Прізвище
Адреса електронної пошти
Дата народження
Додайте конструктори, які приймають наступні параметри:
Всі чотири параметри.
Ім’я, прізвище, адреса електронної пошти.
Ім’я, прізвище, дата народження
Додайте властивості лише для читання, які повертають наступну обчислену 
інформацію:
IsAdult - який повертає true, якщо особа старше 18 років
SunSign - традиційний західний сонячний знак цієї людини
ChineseSign - китайський астрологічний знак цієї людини
IsBirthday – який повертає true, якщо сьогодні день народження людини
Створіть вікно в яке користувач зможе ввести ім’я, прізвище, електронну 
адресу, дату народження. Додайте кнопку Proceed. Кнопка повинна бути 
неактивною, якщо хоча б одне поле не заповнене. Після натискання кнопки, 
повинні бути виконані перевірки 3 та 5 з Лабораторної роботи 1. Якщо 
перевірки пройшли успішно, вивести значення всіх 8-ми полів класу 
Правила виконання роботи:

Потрібно по максимум приховувати компоненти. Public використовувати лише там, де це необхідно.
Дотримуйтесь правил описаних в попередній роботі
Потрібно створити новий репозиторій для даного завдання.

//Task 3
Уважно подумайте деякий час про свою програму з Лабораторної роботи №2 і обдумайте речі, 
які можуть стати неефективними при її використанні. Наприклад, не можна створювати людей, 
які ще не народжені. Крім того, дійсна адреса електронної пошти має форму joeschmoe@mydomain.com.
 
Знайдіть класи Exception у ієрархії класу CLI, які відповідають проблемам, які ви можете знайти. 
У багатьох випадках ви не знайдете відповідний клас. Реалізуйте свої класи, які передають відповідну 
помилку. Принаймні ви повинні реалізувати наступні класи помилок:
1.      Дата народження в майбутньому
2.      Дата народження в минулому дуже далеко (ми маємо справу лише з живими людьми).
3.      Невірна адреса електронної пошти
Напевно, є ще багато помилок, які ви можете реалізувати. Вам не потрібно робити надзвичайно 
надійну перевірку на адресу електронної пошти. Просто простий приклад перевірки, щоб показати, 
що ви знаєте якої вона повинна бути. Додайте код у клас Person і інші частини застосунку, 
який викидає ці помилки, якщо проблемна умова виконано. 
Правила виконання роботи:

1.      Дотримуйтесь правил описаних в попередній роботі
Потрібно використати репозиторій з другої лабораторної роботи для даного завдання.