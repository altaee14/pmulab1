using Telegram.Bot;
using System;
using Telegram.Bot.Types;
using System.Threading;
using Telegram.Bot.Types.Enums;
using Microsoft.VisualBasic;

namespace FilmBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TelegramBotClient("6736941012:AAGykQjgtXbF1JmqL-zrI23qb1AjarQVsNo");
            client.StartReceiving(Update, Error);
            Console.ReadLine();
        }


        async static Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;

            if (message.Text == "Комедия")
            {
                await client.SendPhotoAsync(
                chatId: message.From.Id,
                photo: InputFile.FromUri("https://img.moviesrankings.com/t/p/w1280/vgWqKtyNWhds8LBPyH6uTwCCpsI.jpg"));
                await client.SendTextMessageAsync(message.Chat.Id, "Мальчишник в Вегасе\n" +
                    "ЖАНР: Комедия\n" +
                    "РЕЙТИНГ: 9/10\n" + "\n" +
                    "СЮЖЕТ:\n" +
                    "Они мечтали устроить незабываемый мальчишник в Вегасе. Но теперь им необходимо вспомнить, что именно произошло: что за ребенок сидит в шкафу номера отеля? Как в ванную попал тигр? Почему у одного из них нет зуба? И, самое главное, куда делся жених? " +
                    "То, что парни вытворяли на вечеринке, не идет ни в какое сравнение с тем, что им придется сделать на трезвую голову, когда они будут шаг за шагом восстанавливать события прошлой ночи.\n" +
                    "\n" +
                    "Приятного просмотра!\n");
                return;
            }

            if (message.Text == "Детектив")
            {
                await client.SendPhotoAsync(
                chatId: message.From.Id,
                photo: InputFile.FromUri("https://strek-time.ru/wp-content/uploads/c/1/4/c1486062cde7df28f03a6c330cf14907.jpeg"));
                await client.SendTextMessageAsync(message.Chat.Id, "Достать ножи\n" +
                    "ЖАНР: Детектив\n" +
                    "РЕЙТИНГ: 8/10\n" + "\n" +
                    "СЮЖЕТ:\n" +
                    "Джон Уик - на первый взгляд, самый обычный среднестатистический американец, который ведет спокойную мирную жизнь. Однако мало кто знает, что он был наёмным убийцей, причём одним из лучших профессионалов в своём деле. После того как сынок главы бандитской группы со своими приятелями угоняет его любимый «Мустанг» 1969 года выпуска, при этом убив его собаку Дейзи, которая была подарком недавно почившей супруги, Джон вынужден вернуться к своему прошлому. Теперь Уик начинает охоту за теми, кто имел неосторожность перейти ему дорогу, и он готов на всё, чтобы отомстить.\n" +
                    "\n" +
                    "Приятного просмотра!\n");
                return;
            }

            if (message.Text == "Боевик")
            {
                await client.SendPhotoAsync(
                chatId: message.From.Id,
                photo: InputFile.FromUri("https://www.fonstola.ru/images/202010/fonstola.ru_411065.jpg"));
                await client.SendTextMessageAsync(message.Chat.Id, "Джон Уик(Все части)\n" +
                    "ЖАНР: Боевик\n" +
                    "РЕЙТИНГ: 8,5/10\n" + "\n" +
                    "СЮЖЕТ:\n" +
                    "Джон Уик - на первый взгляд, самый обычный среднестатистический американец, который ведет спокойную мирную жизнь. Однако мало кто знает, что он был наёмным убийцей, причём одним из лучших профессионалов в своём деле. После того как сынок главы бандитской группы со своими приятелями угоняет его любимый «Мустанг» 1969 года выпуска, при этом убив его собаку Дейзи, которая была подарком недавно почившей супруги, Джон вынужден вернуться к своему прошлому. Теперь Уик начинает охоту за теми, кто имел неосторожность перейти ему дорогу, и он готов на всё, чтобы отомстить.\n" +
                    "\n" +
                    "Приятного просмотра!\n");
                return;
            }

            if (message.Text != null || message.Text == "Боевик" || message.Text == "Комедия" || message.Text == "Детектив")
            {
                await client.SendTextMessageAsync(message.Chat.Id, "Фильм какого жанра вы хотите посмотреть?\n" +
                    "(Комедия Боевик Детектив)");
                await client.SendTextMessageAsync(message.Chat.Id, "Комедия\n" +
                    "Боевик\n" +
                    "Детектив");
                return;
            }
        }
        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}