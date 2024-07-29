using CSharpFunctionalExtensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using DataReader.Core.Contracts.Params;
using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;
using DataReader.Core.ValueObjects.Project;
using DataReader.Core.Abstractions.Services.Parsers;


namespace DataReader.Application.ParseProcess
{
  public class ProjectsJsonParserService : IProjectsJsonParserService
  {
    public ProjectsJsonParserService() { }

    public Result<List<ProjectsDTOParam>?> ParseProject(string json)
    {
      try
      {
        List<ProjectsDTOParam>? result = new();
        List<ProjectParam>? projectParam = new();

        //userParam = JsonConvert.DeserializeObject<List<UserParam>>(json);

        JObject obj = JObject.Parse(json);
        JArray array = (JArray)obj["value"];

        //if (array == null)
        //{
        //  return Result.Failure<List<UsersDTOParam>?>("empty json");
        //}

        if (array.Count != 0)
        {
          projectParam = FillProjectParamList(array);
          result = FillResultList(projectParam);
        }

        return Result.Success<List<ProjectsDTOParam>?>(result);
      }

      catch (Exception ex)
      {
        return Result.Failure<List<ProjectsDTOParam>?>(ex.Message);
      }
    }

    private List<ProjectParam> FillProjectParamList(JArray array)
    {
      List<ProjectParam>? temp = new();

      foreach (var item in array)
      {
        DataReaderGuid projectSK = DataReaderGuid.Create((Guid)item["ProjectSK"]).Value;
        DataReaderGuid projectID = DataReaderGuid.Create((Guid)item["ProjectID"]).Value;
        ProjectName projectName = ProjectName.Create(item["ProjectID"].ToString()).Value;

        AnalyticsUpdatedDate analytics =
          AnalyticsUpdatedDate.
          Create(item["AnalyticsUpdatedDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        string? projectVisibility = item["ProjectVisibility"].ToString();

        ProjectParam param = new(projectSK, projectID, projectName, analytics, projectVisibility);
        temp.Add(param);
      }

      return temp;
    }

    private List<ProjectsDTOParam> FillResultList(List<ProjectParam> projectParam)
    {
      List<ProjectsDTOParam>? temp = new();

      foreach (var param in projectParam)
      {
        ProjectsDTOParam dto = new(param);
        temp.Add(dto);
      }

      return temp;
    }
  }
}
