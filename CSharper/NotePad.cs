using System;
using System.Collections.Generic;
using System.Text;

namespace CSharper
{
    internal class NotePad
	{
		#region GrupHastaneDilDesteği

		//		GRUPHASTANE DIL DESTEĞI

		//ÖrnekAPI** City
		//1- GrupHastaneLocale Oluşurma --> Domain.Entities++
		//2- GrupHastane Düzenleme --> Domain.Entities++
		//3- GrupHastaneLocale için --> Infra.Data++
		//						  --> Infra.Data.Database.Context++
		//						  --> Infra.Data.UnitOfWork.UnitOfWork && Infra.Data.UnitOfWork.IUnitOfWork++		  
		//4- GrupHastane Service Üzerine CreateBulk
		//5- GrupHastane Service Üzerine UpdateBulk
		//6- GrupHastane Service Üzerine GetAllCityWitLocale w->Dto's ++++++++++
		//7- GrupHastaneLocale Service DTO Önceliklendirilebilir !! CreateEstablishmentGroupLocaleDTO and UpdateEstablishmentGroupLocaleDTO ++++
		//8- GrupHastaneLocale Service CRUD
		//9- GrupHastaneLocale Service EndPoint

		////////////////////////////////////////////////////////////////////////////////////////////////
		//1----
		//        public string Name { get; set; }

		//		[ForeignKey("Language")]

		//		public long LanguageId { get; set; }

		//		[System.Text.Json.Serialization.JsonIgnore]
		//		[Newtonsoft.Json.JsonIgnore]
		//		public virtual Language Language { get; set; }

		//		public long EstablishmentGroupId { get; set; }

		//		[System.Text.Json.Serialization.JsonIgnore]
		//		[Newtonsoft.Json.JsonIgnore]
		//		public virtual EstablishmentGroup EstablishmentGroup { get; set; }

		//2----
		//		[System.Text.Json.Serialization.JsonIgnore]
		//		[Newtonsoft.Json.JsonIgnore]
		//		public virtual ICollection<EstablishmentGroupLocale> EstablishmentGroupLocaleList { get; set; }

		//3----Infra.Data.Database.Context

		//		public DbSet<EstablishmentGroupLocale> EstablishmentGroupLocale { get; set; }

		//	-Infra.Data.UnitOfWork.IUnitOfWork

		//		IBaseRepository<EstablishmentGroupLocale> EstablishmentGroupLocaleRepository { get; }

		//	-Infra.Data.UnitOfWork.UnitOfWork

		//		private readonly<IBaseRepository<EstablishmentGroupLocale>> establishmentGroupLocaleRepository;

		//		establishmentGroupLocaleRepository = CreateRepository<EstablishmentGroupLocale>(_dbContext);

		//		public IBaseRepository<EstablishmentGroupLocale> EstablishmentGroupLocaleRepository { get { return establishmentGroupLocaleRepository.Value; } }

		//4*5*6-----CreateBulk

		//	DTO


		//	CreateDto ve UpdateDto üzerine ek olarak

		//		public string establishmentGroupLocaleList { get; set; }

		//# validation

		//		Normal create ek olarak 

		//	if (!string.IsNullOrWhiteSpace(request.EstablishmentGroupLocaleList))
		//            {
		//                var establishmentGroupLocaleObj = request.EstablishmentGroupLocaleList.ToObjectSnakeCase<List<EstablishmentGroupLocaleRequestDto>>();
		//                foreach (var locale in establishmentGroupLocaleObj)
		//                {
		//                    var resultLanguageValidator = await _languageValidation.LanguageValidator(locale.LanguageId, locale.LanguageCode);
		//                    if (resultLanguageValidator.Success == false)
		//                    {
		//                        return resultLanguageValidator;
		//                    }
		//	locale.LanguageId = resultLanguageValidator.Language.Id;
		//                }
		//            }

		//	#endOfValidation

		//	create ile normal dosya işlemi...
		//	map map map


		//	using command and after code

		#endregion

		#region ex1

		//if (entity.Status == Status.Ok)
		//{
		//    entity.Status = Status.UnPublished;
		//}

		//if (entity.Status == Status.UnPublished)
		//{
		//    var EstablishmentPublishVersion = await _uow.EstablishmentRepository
		//        .FindByConditionWithoutTracking(q => q.RelatedId == entity.RelatedId && q.Status == Status.Ok)
		//        .FirstOrDefaultAsync();
		//    if (EstablishmentPublishVersion != null)
		//    {
		//        return new ResponseBase()
		//        {
		//            Success = false,
		//            ErrorCode = ErrorCodeEnum.BadRequest,
		//            ErrorMessage = ValidationResource.Exception_Establishment_AlreadyPublishVersion


		//        };

		//    }

		//    entity.Status = Status.Ok;
		//}
		//foreing key merethottt unitofwork.
		//    branch treatment hatası vs ona bakılılcak
		//exception handle middleware xdxd 

		#endregion

		#region ex2

		/*
         *            if (!string.IsNullOrWhiteSpace(request.EstablishmentTypeIds))
            {
                List<long?> ids = new List<long?>();
                request.CurrencyIds.Split(",").ToList().ForEach(f => ids.Add(Convert.ToInt64(f)));
                queryable = queryable.Where(s => ids.Contains(s.EstablishmentTypeId));
            }
			
			
			              EstablishmentBranchCount = est.EstablishmentBranchList.Count(),
                            EstablishmentDoctorCount = est.EstablishmentDoctorList.Count()
							
							
							.TableByCondition(q => q.Status != Status.Deleted)
							
							if (string.IsNullOrEmpty(user.MilesAndSmilesCode))
            {
                response.StatusCode = (int)StatusCodeEnum.Notfound;
                response.ErrorMessage = ValidationResource.Exception_User_NotFound;
                return response;
            }

         *
         *
         */

		#endregion


	}
}
