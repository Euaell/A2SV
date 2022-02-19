struct ListNode {
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        auto ret = new ListNode();
        auto nodePtr = ret;
        int carry = 0;
        while (l1 && l2){
            int sum = l1->val + l2->val + carry;
            nodePtr->val = sum % 10;
            carry = sum / 10;
            l1 = l1->next;
            l2 = l2->next;
            if (l1&&l2)
                nodePtr->next = new ListNode();
            else if(l1)
                nodePtr->next = l1;
            else if(l2)
                nodePtr->next = l2;
            else if (carry != 0)
                nodePtr->next = new ListNode(carry);
            nodePtr = nodePtr->next;
        }
        if (l1){
            while (l1){
                int sum = carry + l1->val;
                nodePtr->val = sum % 10;
                carry = sum / 10;
                l1 = l1->next;
                if (l1)
                    nodePtr = nodePtr->next = new ListNode();
                else if (carry != 0)
                    nodePtr = nodePtr->next = new ListNode(carry);
                else
                    nodePtr = nullptr;
            }
        }else if (l2){
            while (l2){
                int sum = carry + l2->val;
                nodePtr->val = sum % 10;
                carry = sum / 10;
                l2 = l2->next;
                if (l2)
                    nodePtr = nodePtr->next = new ListNode();
                else if (carry != 0)
                    nodePtr = nodePtr->next = new ListNode(carry);
                else
                    nodePtr = nullptr;
            }
        }

        return ret;
    }
};