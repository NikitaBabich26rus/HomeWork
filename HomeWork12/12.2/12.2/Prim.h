#pragma once

// ������������ ����������
const int maxDistance = 1000000000;

// ����� � ������ �������
const int size = 100;

// �������� �����
void prim(int graph[][size], int sizeOfGraph, int parent[], int startVertex);

// ������� ��������� ���������
void outputResult(int array[], int sizeOfGraph);