class Solution:
    def reverseParentheses(self, s: str) -> str:
        stack = []
        answer=""
        counter =0
        for i in range(0,len(s)):
            if s[i]=="(":
                counter +=1
                stack.append(s[i])
            elif s[i] ==")":
                counter -=1
                stack2=[]
                a=stack.pop()
                while( not a=='('):
                    stack2.append(a)
                    a=stack.pop()
                # print(stack2)    
                      
                for i in range(0,len(stack2)):
                    stack.append(stack2[i])
                    
                   
                if counter == 0:
                    
                    while(counter<len(stack)):
                        answer=answer+stack[counter]
                        stack.pop(counter)
                        
                        
            elif not counter == 0 :
                stack.append(s[i])
                
                    
            elif counter==0 and not s[i] =='(' and not s[i] ==')':
               
                answer += s[i]
                   
        return answer 
