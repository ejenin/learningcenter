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

            //model.actualGroups.Add(new Group() {
            //    Id = 0,
            //    DateStart = new DateTime(2017, 05, 15),
            //    DateEnd = new DateTime(2017, 05, 17),
            //    GroupName = "17-67-0001",
            //    Area = "г. Тобольск, 9 мкр.",
            //    Course = "Навыки высокоэффективных людей",
            //    Lecturer = "Иванов И.И."
            //});

            model.actualGroups.Add(new Group() {
                Id = 0,
                DateStart = new DateTime(2017, 06, 01),
                DateEnd = new DateTime(2017, 06, 03),
                GroupName = "17-67-0002",
                Area = "Рабочее место",
                Course = "Основы кибербезопасности",
                //Lecturer = "Петренко С.В."
                Lecturer = "-"
            });


            model.futureGroups.Add(new Group() {
                Id = 3,
                DateStart = new DateTime(2017, 04, 04),
                DateEnd = new DateTime(2017, 04, 05),
                GroupName = "17-67-0004",
                Area = "Рабочее место",
                Course = "Обучение Excel",
                //Lecturer = "Иванов И.И."
                Lecturer = "-"
            });

            model.futureGroups.Add(new Group() {
                Id = 3,
                DateStart = new DateTime(2017, 04, 06),
                DateEnd = new DateTime(2017, 04, 09),
                GroupName = "17-67-0005",
                Area = "г.Тюмень, Моск-ий тракт, 421",
                Course = "Мастерство Power Point",
                Lecturer = "Сергеев П.П."
            });

            model.futureGroups.Add(new Group() {
                Id = 3,
                DateStart = new DateTime(2017, 04, 10),
                DateEnd = new DateTime(2017, 04, 10),
                GroupName = "17-67-0006",
                Area = "г.Тюмень, Моск-ий тракт, 423",
                Course = "Тайм-менеджмент",
                Lecturer = "Сидоренко В.В."
            });

            model.futureGroups.Add(new Group() {
                Id = 3,
                DateStart = new DateTime(2017, 04, 12),
                DateEnd = new DateTime(2017, 04, 14),
                GroupName = "17-67-0007",
                Area = "Рабочее место",
                Course = "Холодные звонки",
                //Lecturer = "Глушкова И.С."
                Lecturer = "-"
            });

            model.futureGroups.Add(new Group() {
                Id = 3,
                DateStart = new DateTime(2017, 04, 20),
                DateEnd = new DateTime(2017, 04, 21),
                GroupName = "17-67-0008",
                Area = "г.Тюмень, Моск-ий тракт, 421",
                Course = "Мастерская продаж",
                Lecturer = "Балановская Д.Ю."
            });


            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 01),
                    DateEnd = new DateTime(2017, 02, 03),
                    GroupName = "17-67-0010",
                    Area = "Рабочее место",
                    Course = "Соло на клавиатуре",
                    //Lecturer = "Иванов И.И."
                    Lecturer = "-"
                },
                IsSuccess = true,
                Mark = "94"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 05),
                    DateEnd = new DateTime(2017, 02, 07),
                    GroupName = "17-67-0011",
                    Area = "г.Тюмень, Моск-ий тракт, 423",
                    Course = "Личная эффективность",
                    Lecturer = "Григорян Ж.Д."
                },
                IsSuccess = false,
                Mark = "32"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 10),
                    DateEnd = new DateTime(2017, 02, 15),
                    GroupName = "17-67-0012",
                    Area = "г.Тюмень, Моск-ий тракт, 421",
                    Course = "Продажа кредитных карт",
                    Lecturer = "Артёмов Е.К."
                },
                IsSuccess = false,
                Mark = "Пропуск занятия"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 05),
                    DateEnd = new DateTime(2017, 02, 07),
                    GroupName = "17-67-0013",
                    Area = "Рабочее место",
                    Course = "Клиентоориентированность",
                    //Lecturer = "Петренко В.П."
                    Lecturer = "-"
                },
                IsSuccess = true,
                Mark = "100"
            });

            model.passedGroups.Add(new LearningResult() {
                Group = new Group() {
                    Id = 0,
                    DateStart = new DateTime(2017, 02, 10),
                    DateEnd = new DateTime(2017, 02, 15),
                    GroupName = "17-67-0014",
                    Area = "Рабочее место",
                    Course = "Обращение с подарками",
                    //Lecturer = "Стасян К.Е."
                    Lecturer = "-"
                },
                IsSuccess = true,
                Mark = "90"
            });

            return View(model);
        }

        public ActionResult Planning() {
            PlanningModel model = new PlanningModel();
            model.BossFio = "Петров Пётр Петрович";
            model.ochnCourses = new List<LearningCourse>();

            model.ochnCourses.Add(new LearningCourse() {
                Id = 1,
                Name = "Холодные звонки",
                IsRemote = false,
                Status = Status.None,
                DateChange = null
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 2,
                Name = "Transact-SQL",
                IsRemote = false,
                Status = Status.ZaplanirovanaAvtomatom,
                DateChange = new DateTime(2017, 04, 13),
                ChosenGroup = new Group() {
                    Area = "г. Тобольск, ул. Мира, 19",
                    DateStart = new DateTime(2017, 04, 10),
                    DateEnd = new DateTime(2017, 04, 12),
                    GroupName = "17-67-2099",
                    Lecturer = "Галошкин П.Е."
                }
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 2,
                Name = "1C Предприятие",
                IsRemote = false,
                Status = Status.ZaplanirovanaAvtomatom,
                DateChange = new DateTime(2017, 04, 13),
                ChosenGroup = new Group() {
                    Area = "г. Тобольск, ул. Мира, 19",
                    DateStart = new DateTime(2017, 04, 24),
                    DateEnd = new DateTime(2017, 04, 26),
                    GroupName = "17-67-2099",
                    Lecturer = "Петренко И.В."
                }
            });

            model.ochnCourses.Add(new LearningCourse() {
                Id = 3,
                Name = "Владение EXCEL 2010",
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
                    Area = "г. Тюмень, Моск-ий тракт, 421",
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
                Course = "Холодные звонки",
                EmployeeFio = "Иванов С.А.",
                IsInWaitingList = false,
                LearningStart = new DateTime(2017, 04, 07),
                LearningEnd = new DateTime(2017, 04, 12),
                Status = BidStatus.WaitingToConfirm
            });

            model.Bids.Add(new Bid() {
                Area = "г. Тюмень, Моск-ий тракт, 421",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Владение Power Point",
                EmployeeFio = "Сидорова А.Н.",
                IsInWaitingList = false,
                LearningStart = new DateTime(2017, 04, 13),
                LearningEnd = new DateTime(2017, 04, 17),
                Status = BidStatus.Rejected
            });

            model.Bids.Add(new Bid() {
                Area = "г. Нижневартовск, ул. Одесская, 4",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Корпоративная культура",
                EmployeeFio = "Иванов С.А.",
                IsInWaitingList = false,
                LearningStart = new DateTime(2017, 04, 18),
                LearningEnd = new DateTime(2017, 04, 22),
                Status = BidStatus.SwappedByHands
            });

            model.Bids.Add(new Bid() {
                Area = "г. Омск, ул. М.Жукова, д.19",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Современное IT",
                EmployeeFio = "Петров Е.Г.",
                IsInWaitingList = false,
                LearningStart = new DateTime(2017, 04, 20),
                LearningEnd = new DateTime(2017, 04, 24),
                Status = BidStatus.SwappedByHands
            });

            model.Bids.Add(new Bid() {
                Area = "г. Тюмень, Моск-ий тракт, 421",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Дизайн-мышление",
                EmployeeFio = "Коротков С.Н.",
                IsInWaitingList = true,
                LearningStart = new DateTime(2017, 05, 10),
                LearningEnd = new DateTime(2017, 05, 14),
                Status = BidStatus.PlannedByAutomate
            });

            model.Bids.Add(new Bid() {
                Area = "г. Тюмень, Моск-ий тракт, 423",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Навыки личной эффективности",
                EmployeeFio = "Вищук С.А.",
                IsInWaitingList = true,
                LearningStart = new DateTime(2017, 05, 02),
                LearningEnd = new DateTime(2017, 05, 04),
                Status = BidStatus.PlannedByAutomate
            });

            model.Bids.Add(new Bid() {
                Area = "г. Тюмень, Моск-ий тракт, 422",
                BidDate = new DateTime(2017, 04, 03),
                Course = "Пожаротехнический минимум",
                EmployeeFio = "Иванчук П.В.",
                IsInWaitingList = true,
                LearningStart = new DateTime(2017, 05, 20),
                LearningEnd = new DateTime(2017, 05, 22),
                Status = BidStatus.PlannedByAutomate
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

        public ActionResult Lecturer(int id) {
            return View();
        }

        public ActionResult Area(int id) {
            return View();
        }

        public ActionResult Group(int id) {
            return View();
        }
    }
}