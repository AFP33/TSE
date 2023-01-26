using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal class BoardOfDirectorDeserializer : IDeserializer<List<BoardOfDirector>>
    {
        public List<BoardOfDirector> Get(string serverResponse)
        {
            try
            {
                if (Common.Useful.IsNullString(serverResponse))
                    throw new System.ArgumentNullException(nameof(serverResponse));

                var boardOfDirectors = new List<BoardOfDirector>();

                var json = JArray.Parse(serverResponse).Children();

                foreach (var item in json)
                {
                    BoardOfDirector boardOfDirector = new BoardOfDirector();
                    boardOfDirector.Title = item[0].Value<string>();
                    boardOfDirector.DateTime = item[1].Value<string>();
                    boardOfDirector.CouncilDate = ((JObject)item[4]["Root"]).ContainsKey("AssemblyDate") ? item[4]["Root"]["AssemblyDate"].Value<string>() : string.Empty;
                    boardOfDirector.BoardDirectorDate = ((JObject)item[4]["Root"]).ContainsKey("BoardMembersSessionDate") ? item[4]["Root"]["BoardMembersSessionDate"].Value<string>() : string.Empty;

                    // Members
                    boardOfDirector.Members = new List<Member>();
                    var allboardMember = item[4]["Root"]["BoardMembers"]["BoardMember"].Children();
                    foreach (var boardMember in allboardMember)
                    {
                        Member member = new Member()
                        {
                            PreviousMemberName = boardMember["PreviousMemberName"].Value<string>(),
                            MemberName = boardMember["MemberName"].Value<string>(),
                            NationalCode_RegisterNumber = boardMember["NationalCode_RegisterNumber"].Value<string>(),
                            PreviuosAgent = boardMember["PreviuosAgent"].Value<string>(),
                            Agent = boardMember["Agent"].Value<string>(),
                            AgentNationalCode = boardMember["AgentNationalCode"].Value<string>(),
                            Designation = boardMember["Designation"].Value<string>(),
                            Charged = boardMember["Charged"].Value<string>(),
                            EducationDegree = boardMember["EducationDegree"].Value<string>()
                        };
                        boardOfDirector.Members.Add(member);
                    }
                    // Director Manager
                    var directorManager = item[4]["Root"]["DirectorManager"];
                    if (directorManager != null)
                    {
                        boardOfDirector.DirectorManager = new DirectorManager()
                        {
                            Name = directorManager["DirectorManagerName"].Value<string>(),
                            NationalCode = directorManager["DirectorManagerNationalCode"].Value<string>(),
                            EducationDegree = directorManager["DirectorManagerEducationDegree"].Value<string>()
                        };
                    }
                    boardOfDirectors.Add(boardOfDirector);
                }

                return boardOfDirectors;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
