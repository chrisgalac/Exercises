/**
 * Definition for singly-linked list with a random pointer.
 * struct RandomListNode {
 *     int label;
 *     RandomListNode *next, *random;
 *     RandomListNode(int x) : label(x), next(NULL), random(NULL) {}
 * };
 */
class Solution {
public:
    RandomListNode *copyRandomList(RandomListNode *head) {
        if(head == NULL) return NULL;
        
        RandomListNode *copyHead = new RandomListNode(head->label);
        
        RandomListNode *l1 = head;
        RandomListNode *l2 = copyHead;
        l2->next = l1->next;
        l2->random = l1->random;
        
        l1->next = l2;
        l1 = l1->next->next;
        while(l1 != NULL){
            l2 = new RandomListNode(l1->label);
            l2->next = l1->next;
            l2->random = l1->random;
            
            l1->next = l2;
            l1 = l1->next->next;
        }
        
        l1 = head;
        l2 = copyHead;
        while(l2 != NULL){
            l2->random = l2->random->next;
            
            l1->next = l2->next;
            if(l2->next != NULL) { l2->next = l2->next->next; }
            
            l1 = l1->next;
            l2 = l2->next;
        }
        
        return copyHead;
    }
};