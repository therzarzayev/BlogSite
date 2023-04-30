﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		private readonly IWriterDal _writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public async Task<Writer> GetWriterByEmail(string email)
		{
		 	return await _writerDal.GetWriterByEmail(email);
		}

		public async Task WriterAdd(Writer writer)
		{
			await _writerDal.AddAsync(writer);
		}
	}
}
