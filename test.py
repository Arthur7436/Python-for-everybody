# public class Solution {
#     public bool IsValid(string s) {
#         string[] options = {"()","{}", "[]"} ;

#         foreach(string option in options){
#             if(s.Contains(option)){
#                 return true;
#             }
#             else{
#                 return false;
#             }
#         }
#         return false;
#     }
# }