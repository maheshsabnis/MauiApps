CReate Database Tasks;

USe Tasks;

Create TAble JobTask(
  TaskId int Identity(1,1) Primary Key,
  TaskName varchar(100) Not Null,
  AssignedTo Varchar(200) Not null,
  AssignedDate DateTime Not Null
)