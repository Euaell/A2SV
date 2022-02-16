class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack =[]
        for i in range(0,len(tokens)):
            if not tokens[i]=="+" and not tokens[i]=="-" and not tokens[i]=="*" and not tokens[i]=="/":
                stack.append(int(tokens[i]))
            elif tokens[i] == "+":
                a = stack.pop()
                b = stack.pop()
                stack.append(a+b)
            elif tokens[i] == "-":
                a = stack.pop()
                b = stack.pop()
                stack.append(b-a)
            elif tokens[i] == "*":
                a = stack.pop()
                b = stack.pop()
                stack.append(a*b)
            elif tokens[i] == "/":
                a = stack.pop()
                b = stack.pop()
                if a*b<0 and not b%a==0:
                    stack.append((b//a)+1)
                else:
                    stack.append(b//a)
        return stack.pop()
