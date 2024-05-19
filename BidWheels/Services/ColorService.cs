using BidWheels.Models;
using BidWheels.Repositories.Interfaces;
using BidWheels.Services.Interfaces;

namespace BidWheels.Services
{
	public class ColorService : IColorService
	{
		private IRepositoryWrapper _repositoryWrapper;

		public ColorService(IRepositoryWrapper repositoryWrapper)
		{
			_repositoryWrapper = repositoryWrapper;
		}

		public List<Color> FindAll()
		{
			return _repositoryWrapper.ColorRepository.FindAll().ToList();
		}

		public Color? FindById(int id)
		{
			return _repositoryWrapper.ColorRepository.FindByCondition(e => e.Id == id).FirstOrDefault();
		}

		public void Create(Color entity)
		{
			_repositoryWrapper.ColorRepository.Create(entity);
			_repositoryWrapper.Save();
		}

		public void Update(Color entity)
		{
			_repositoryWrapper.ColorRepository.Update(entity);
			_repositoryWrapper.Save();
		}

		public void Delete(Color entity)
		{
			_repositoryWrapper.ColorRepository.Delete(entity);
			_repositoryWrapper.Save();
		}
	}
}