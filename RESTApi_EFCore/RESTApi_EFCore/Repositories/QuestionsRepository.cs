using Microsoft.EntityFrameworkCore;
using RESTApi_EFCore.Data;
using RESTApi_EFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApi_EFCore.Repositories
{
    internal static class QuestionsRepository
    {
        internal async static Task<List<Question>> GetQuestionsAsync()
        {
            using(var db = new AppDBContext())
            {
                return await db.Questions.ToListAsync();
            }
        }

        internal async static Task<Question> getQuestionByIdAsync(int questionId)
        {
            using (var db = new AppDBContext())
            {
                return await db.Questions.FirstOrDefaultAsync(question => question.QuestionId == questionId );
            }
        }

        internal async static Task<bool> addQuestionAsync(Question q)
        {
            using (var db = new AppDBContext())
            {
               try
               {
                    await db.Questions.AddAsync(q);
                    return await db.SaveChangesAsync() >= 1;

               } catch (Exception ex)
               {
                    return false;
               }
            }
        }

        internal async static Task<bool> updateQuestionAsync(Question q)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    db.Questions.Update(q);
                    return await db.SaveChangesAsync() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> deletePostAsync(int questionId)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    Question qToDelete = await getQuestionByIdAsync(questionId);
                    db.Questions.Remove(qToDelete);
                    return await db.SaveChangesAsync() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
