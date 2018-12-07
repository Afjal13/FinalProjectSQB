using SecureQuestionBankV0._1._3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecureQuestionBankV0._1._3.Controllers
{
    public class SubAdminTrafficController : Controller
    {
        // GET: SubAdminTraffic
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            string questiontype = frm["QuestionType"].ToString();

            return RedirectToAction(questiontype);
        }
        [HttpGet]
        public ActionResult MCQ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MCQ(MCQRecord mCQRecord)
        {
           try
            {
                
                   if (ModelState.IsValid)
                    {
                        MCQRecordDb mcqqrdb = new MCQRecordDb();
                        if (mcqqrdb.AddMCQRecord(mCQRecord))
                        {
                            ViewBag.Message = "Sub Admin Details Added Successfully";
                            ModelState.Clear();
                        }
                  
                }
                return View("CreateMCQ");
            }
            catch
            {
                ViewBag.Message = "Sub Admin Details Added not Successfully";
                return View();
            }

        }

        [HttpGet]
        public ActionResult CreateMCQ()
        {
           
            
          return View();
        }

        [HttpPost]
        public ActionResult CreateMCQ(CreateMCQ createMCQ)
        {
            int x = Convert.ToInt32(createMCQ.QuestionNo);
            int count=0;
            int i = 2;
            if (count <= i)
            {

                count++;
                return View();
            }

            return View();
        }

        // GET: Upload Question// by subadmin
        [HttpGet]
        public ActionResult Upload()
        {
            
                return View();
           
        }

        // POST: Upload Question
        [HttpPost]
        public ActionResult Upload(UploadQuestion notice)
        {
            notice.FileName = Path.GetFileNameWithoutExtension(notice.Files.FileName);
            notice.FilePath = notice.FileName + System.IO.Path.GetExtension(notice.Files.FileName);
            string fileName = "~/QuestionFiles/" + notice.FileName + System.IO.Path.GetExtension(notice.Files.FileName);
            notice.Files.SaveAs(Server.MapPath(fileName));
            try
            {
                if (ModelState.IsValid)
                {
                    if (notice.publishNotice())
                    {
                        ViewBag.Message = "Publish successfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Sorry! try again.";
                    }
                    return View();
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: /ViewQuestion // by subadmin
        [HttpGet]
        public ActionResult qsnView()
        {
            UploadQuestion notice = new UploadQuestion();
            notice.Data = notice.viewNotices();
            return View(notice);
        }

        // POST: ViewQuestion 
        [HttpPost]
        public ActionResult qsnView(UploadQuestion notice)
        {
            notice.Data = notice.viewNotices();
            return View(notice);
        }

         // Download question file
        [HttpGet]
        public FileResult DownloadFile(int id, UploadQuestion obj)
        {
            obj.GetFiles(id);
            string filepath = Server.MapPath("~/QuestionFiles/" + obj.FilePath);

            return File(filepath, "application/pdf", obj.FileName + ".pdf");
        }

        // Delete Question// by subadmin
        public ActionResult DeleteFile(int id)
        {
            try
            {
                UploadQuestion notice = new UploadQuestion();
                if (notice.deleteFile(id))
                {
                    ViewBag.AlertMsg = "Delete Successfully";
                }
                return RedirectToAction("ViewNotice");
            }
            catch
            {
                return RedirectToAction("ViewNotice"); ;
            }
        }

        
        [HttpGet]
        public ActionResult Notice()
        {
            UploadQuestion notice = new UploadQuestion();
            notice.Data = notice.viewNotices();
            return View(notice);
        }

        [HttpPost]
        public ActionResult Notice(UploadQuestion notice)
        {
            notice.Data = notice.viewNotices();
            return View(notice);
        }
        [HttpGet]
        public ActionResult ProfileView()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Send()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(QuestionUpdate QUP)
        {
            return View("MCQUpdate");
        }
        public ActionResult MCQUpdate()
        {
            return View();
        }

    }
}