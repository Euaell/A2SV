class Solution:
    def isValid(self, s: str) -> bool:
        length = len(s)
        arr =[]
        count =0
        balanced = True
        if not length%2 == 0:
            balanced = False 
            return balanced
        else:
            for i in range(0,length):
                
                if s[i]=="{" or s[i]=="[" or s[i]=="(":
                    arr.append(s[i])
                    count = count+1
                else :
                    if s[i]==")" and not len(arr)==0 and arr.pop()=="(":
                        count=count-1
                        continue
                    elif s[i]=="]" and not len(arr)==0 and arr.pop()=="[":
                        count=count-1
                        continue
                    elif s[i]=="}" and not len(arr)==0 and arr.pop()=="{":
                        count=count-1
                        continue
                    else :
                        balanced = False
                        return balanced
                        
        if not count ==0:
            return False
        return True
