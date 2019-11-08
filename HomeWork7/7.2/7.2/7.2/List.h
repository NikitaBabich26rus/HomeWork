#pragma once

// �������� ������
struct ListElement;

// ������
struct List;

// ������� ������
List* createList();

// �������� ������ �� ������� ���������
bool empty(List* head);

// �������� ������� � ������
void push(List* list, int value);

// ������� ������� �� ������
void deleteElement(List* list, ListElement* value);

// ����� ������
void outputList(List* list);

// ���������� ���������
int algorithm(int size, int count);