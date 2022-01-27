using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeek.DataAccess.Interfaces;
using ThirdWeekModel.Entities;

namespace ThirdWeek.DataAccess.Concrete
{
    public class CommentRepository : GenericRepository<Comment, ThirdWeekDbContext>, ICommentRepository
    {
    }
}
