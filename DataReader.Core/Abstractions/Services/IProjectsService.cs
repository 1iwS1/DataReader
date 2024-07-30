using CSharpFunctionalExtensions;

using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Abstractions.Services
{
  public interface IProjectsService
  {
    //Task<Result> CreateProject(Project user);
    //Task<Result<Project>> GetProject(DataReaderGuid projectId);
    //Task<Result> UpdateProject(DataReaderGuid projectId);
    Task<Result> SyncProject(ProjectsRequest projectsRequest);
  }
}