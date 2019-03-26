﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthDiseasePrediction
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HeartDiseasePredictionEntities3 : DbContext
    {
        public HeartDiseasePredictionEntities3()
            : base("name=HeartDiseasePredictionEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChestPainType> ChestPainTypes { get; set; }
        public virtual DbSet<HDPModel> HDPModels { get; set; }
        public virtual DbSet<HeartDiseaseTrainingSet> HeartDiseaseTrainingSets { get; set; }
        public virtual DbSet<RestingElectroCardiographicResult> RestingElectroCardiographicResults { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        [DbFunction("HeartDiseasePredictionEntities3", "HDPFE")]
        public virtual IQueryable<HDPFE_Result> HDPFE(Nullable<int> idChestPainType, Nullable<double> maxHeartRateAchived, Nullable<double> oldpeak)
        {
            var idChestPainTypeParameter = idChestPainType.HasValue ?
                new ObjectParameter("IdChestPainType", idChestPainType) :
                new ObjectParameter("IdChestPainType", typeof(int));
    
            var maxHeartRateAchivedParameter = maxHeartRateAchived.HasValue ?
                new ObjectParameter("MaxHeartRateAchived", maxHeartRateAchived) :
                new ObjectParameter("MaxHeartRateAchived", typeof(double));
    
            var oldpeakParameter = oldpeak.HasValue ?
                new ObjectParameter("Oldpeak", oldpeak) :
                new ObjectParameter("Oldpeak", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<HDPFE_Result>("[HeartDiseasePredictionEntities3].[HDPFE](@IdChestPainType, @MaxHeartRateAchived, @Oldpeak)", idChestPainTypeParameter, maxHeartRateAchivedParameter, oldpeakParameter);
        }
    
        public virtual int ModelTraining(ObjectParameter trained_model)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModelTraining", trained_model);
        }
    
        public virtual int Prediction(string model, string query)
        {
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            var queryParameter = query != null ?
                new ObjectParameter("query", query) :
                new ObjectParameter("query", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Prediction", modelParameter, queryParameter);
        }
    }
}
