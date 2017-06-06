using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testProject.Misc;
using testProject.Models.ViewModels;
using testProject.Models.ViewModels.Confirm;
using testProject.Models.ViewModels.MyGroups;
using testProject.Models.ViewModels.Planning;

namespace testProject.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/

        public ActionResult Feed() {
            FeedModel feed = new FeedModel();

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                CreateDate = DateTime.Now,
                Id = 0,
                Header = "Вам назначены новые курсы!",
                Text = "Перейдите в раздел \"Планирование\" для подробной информации",
                Type = Models.ViewModels.Feed.NewsType.Information,
                ReaderId = 0,
                ReadDate = DateTime.Now
            });

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                CreateDate = DateTime.Now,
                Id = 1,
                Header = "Ваша заявка согласована!",
                Text = "Руководитель согласовал вашу заявку на обучение! Перейдите в раздел \"Планирование\" для подробной информации",
                Type = Models.ViewModels.Feed.NewsType.Positive,
                ReaderId = 0,
                ReadDate = DateTime.Now
            });

            feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
                CreateDate = DateTime.Now,
                Id = 2,
                Header = "Ваше обучение было отменено!",
                Text = "Одна из групп, в которой вы должны были проходить обучение, была отменена. Подробнее по ссылке",
                Type = Models.ViewModels.Feed.NewsType.Negative,
                ReaderId = 0
            });
            //feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
            //    Id = 0,
            //    CreateDate = DateTime.Now,
            //    Text = "Пример информационной новости",
            //    Header = "Заголовок информационной непрочитанной новости",
            //    Type = Models.ViewModels.Feed.NewsType.Information,
            //    ReaderId = 0
            //});

            //feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
            //    Id = 1,
            //    CreateDate = DateTime.Now,
            //    Text = "Пример позитивной новости",
            //    Header = "Заголовок позитивной непрочитанной новости",
            //    Type = Models.ViewModels.Feed.NewsType.Positive,
            //    ReaderId = 0
            //});

            //feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
            //    Id = 2,
            //    CreateDate = DateTime.Now,
            //    Text = "Пример негативной новости",
            //    Header = "Заголовок негативной непрочитанной новости",
            //    Type = Models.ViewModels.Feed.NewsType.Negative,
            //    ReaderId = 0
            //});

            //feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
            //    Id = 3,
            //    CreateDate = DateTime.Now,
            //    Text = "Пример информационной новости",
            //    Header = "Заголовок информационной прочитанной новости",
            //    Type = Models.ViewModels.Feed.NewsType.Information,
            //    ReaderId = 0,
            //    ReadDate = new DateTime(2017,05,05)
            //});

            //feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
            //    Id = 4,
            //    CreateDate = DateTime.Now,
            //    Text = "Пример позитивной новости",
            //    Header = "Заголовок позитивной прочитанной новости",
            //    Type = Models.ViewModels.Feed.NewsType.Positive,
            //    ReaderId = 0,
            //    ReadDate = new DateTime(2017, 05, 05)
            //});

            //feed.newsToShow.Add(new Models.ViewModels.Feed.News() {
            //    Id = 5,
            //    CreateDate = DateTime.Now,
            //    Text = "Пример негативной новости",
            //    Header = "Заголовок негативной прочитанной новости",
            //    Type = Models.ViewModels.Feed.NewsType.Negative,
            //    ReaderId = 0,
            //    ReadDate = new DateTime(2017, 05, 05)
            //});

            feed.newsToShow = feed.newsToShow.OrderByDescending(n => n.Id).ToList();

            return View(feed);
        }

        public ActionResult MyLearning() {
            MyLearningModel model = new MyLearningModel();

            DateTime start = new DateTime(2017, 03, 19);
            DateTime end = new DateTime(2017, 03, 24);

            model.actualGroups.Add(new Group() {
                Id = 3,
                DateStart = new DateTime(2017, 04, 04),
                DateEnd = new DateTime(2017, 04, 16),
                GroupName = "17-67-0004",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Иванов И.И."
            });



            model.futureGroups.Add(new Group() {
                Id = 0,
                DateStart = new DateTime(2017, 05, 15),
                DateEnd = new DateTime(2017, 05, 17),
                GroupName = "17-67-0001",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Иванов И.И."
            });

            model.futureGroups.Add(new Group() {
                Id = 0,
                DateStart = new DateTime(2017, 06, 01),
                DateEnd = new DateTime(2017, 06, 03),
                GroupName = "17-67-0001",
                Area = "г. Тобольск, 9 мкр.",
                Course = "Курс 1",
                Lecturer = "Иванов И.И."
            });



            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 01),
                    DateEnd = new DateTime(2017, 02, 03),
                    GroupName = "17-67-0001",
                    Area = "г. Тобольск, 9 мкр.",
                    Course = "Курс 1",
                    Lecturer = "Иванов И.И."
                },
                IsSuccess = true,
                Mark = "4"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 05),
                    DateEnd = new DateTime(2017, 02, 07),
                    GroupName = "17-67-0001",
                    Area = "г. Тобольск, 9 мкр.",
                    Course = "Курс 1",
                    Lecturer = "Иванов И.И."
                },
                IsSuccess = false,
                Mark = "2"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 10),
                    DateEnd = new DateTime(2017, 02, 15),
                    GroupName = "17-67-0001",
                    Area = "г. Тобольск, 9 мкр.",
                    Course = "Курс 1",
                    Lecturer = "Иванов И.И."
                },
                IsSuccess = false,
                Mark = "Пропуск занятия"
            });

            return View(model);
        }

        public ActionResult Planning() {
            PlanningModel model = new PlanningModel();
            model.BossFio = "Петров Пётр Петрович";
            model.ochnCourses = new List<LearningCourse>();

            model.ochnCourses.Add(new LearningCourse() {
                Id = 1,
                Name = "Мастерство владения холодными звонками (уровень 2)",
                IsRemote = false,
                Status = Status.None,
                DateChange = null
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 2,
                Name = "Мастерство владения холодными (уровень 1)",
                IsRemote = false,
                Status = Status.NaSoglasovanii,
                DateChange = new DateTime(2017, 04, 13)
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 3,
                Name = "Курсы по EXCEL 2010",
                IsRemote = false,
                Status = Status.Otkazana,
                DateChange = new DateTime(2017, 03, 30)
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 3,
                Name = "Развитие лидерских качеств",
                IsRemote = false,
                Status = Status.Soglasovana,
                ChosenGroup = new Group() {
                    Area = "г. Тобольск, ул. Мира, 19",
                    DateStart = new DateTime(2017, 04, 10),
                    DateEnd = new DateTime(2017, 04, 12),
                    GroupName = "17-67-2099",
                    Lecturer = "Иванов Е.С."
                },
                DateChange = new DateTime(2017, 04, 13)
            });

            model.distCourses.Add(new LearningCourse() {
                Id = 4,
                Name = "Обращение с подарками",
                IsRemote = true,
                Status = Status.None
            });

            model.distCourses.Add(new LearningCourse() {
                Id = 5,
                Name = "Проблемы при работе с кредитами",
                IsRemote = true,
                Status = Status.None
            });

            model.distCourses.Add(new LearningCourse() {
                Id = 6,
                Name = "Соло на клавиатуре",
                IsRemote = true,
                Status = Status.None
            });

            model.ochnCourses = model.ochnCourses.OrderBy(o => o.Status).ToList();

            return View(model);
        }

        public ActionResult Confirm() {
            if (Globals.CurrentMode != Mode.BOSS) {
                return Redirect("/home/feed");
            }

            //туду: здесь - 
            //1) взять все заявки (по дате поступления)
            /*
             * У заявки есть - СОТРУДНИК, ДАТА ПОДАЧИ ЗАЯВКИ, КУРС, КОГДА ЧЕЛИК ХОЧЕТ УЧИТЬСЯ, ГДЕ ХОЧЕТ УЧИТЬСЯ, СТАТУС ЗАЯВКИ
             */
            //2) ПАГИНАЦИЯ
            //3) тот самый компонент с визуальным отображением. Что? куча дивов? канвас? обычный битмап?
            //4) лист ожидания. Надо всё таки его блять сделать.

            //DateTime bidDate = new DateTime(2017, 03, 03);
            //DateTime LearningStart = new DateTime(2017, 03, 15);
            //DateTime LearningEnd = new DateTime(2017, 03, 20);

            ConfirmModel model = new ConfirmModel();
            model.Bids.Add(new Bid() {
                Area = "г. Тобольск, ул. Мира, дом 9",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Мастерство владения холодными звонками",
                EmployeeFio = "Иванов С.А.",
                IsInWaitingList = false,
                LearningStart = new DateTime(2017, 04, 07),
                LearningEnd = new DateTime(2017, 04, 12),
                Status = BidStatus.WaitingToConfirm
            });

            model.Bids.Add(new Bid() {
                Area = "г. Тобольск, ул. Мира, дом 9",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Мастерство владения холодными звонками",
                EmployeeFio = "Сидорова А.Н.",
                IsInWaitingList = false,
                LearningStart = new DateTime(2017, 04, 13),
                LearningEnd = new DateTime(2017, 04, 17),
                Status = BidStatus.Rejected
            });

            model.Bids.Add(new Bid() {
                Area = "г. Тобольск, ул. Мира, дом 9",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Мастерство владения холодными звонками (уровень 2)",
                EmployeeFio = "Иванов С.А.",
                IsInWaitingList = false,
                LearningStart = new DateTime(2017, 04, 18),
                LearningEnd = new DateTime(2017, 04, 22),
                Status = BidStatus.SwappedByHands
            });

            model.Bids.Add(new Bid() {
                Area = "г. Тобольск, ул. Мира, дом 9",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Мастерство владения холодными звонками",
                EmployeeFio = "Петров Е.Г.",
                IsInWaitingList = true,
                LearningStart = new DateTime(2017, 04, 20),
                LearningEnd = new DateTime(2017, 04, 24),
                Status = BidStatus.Confirmed
            });


            //model.WaitingBids.Add(new Bid() {
            //    Area = "г. Тобольск, ул. Мира, дом 9",
            //    BidDate = new DateTime(2017, 04, 03),
            //    Course = "Мастерство владения холодными звонками",
            //    EmployeeFio = "Хорищенко Е.К.",
            //    IsInWaitingList = true,
            //    LearningStart = new DateTime(2017, 04, 20),
            //    LearningEnd = new DateTime(2017, 04, 24),
            //    Status = BidStatus.Confirmed
            //});


            model.Bids = model.Bids.OrderByDescending(b => b.Status).ToList();
            model.WaitingBids = model.WaitingBids.OrderByDescending(b => b.Status).ToList();

            return View(model);
        }

    }
}