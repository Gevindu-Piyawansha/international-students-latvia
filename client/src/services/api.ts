import axios from 'axios';

const API_BASE_URL = 'https://localhost:7001/api';

export const api = axios.create({
  baseURL: API_BASE_URL,
  headers: {
    'Content-Type': 'application/json',
  },
});

// Apartment API calls
export const apartmentApi = {
  getAll: () => api.get('/apartments'),
  getById: (id: string) => api.get(`/apartments/${id}`),
  create: (apartment: any) => api.post('/apartments', apartment),
  update: (id: string, apartment: any) => api.put(`/apartments/${id}`, apartment),
  delete: (id: string) => api.delete(`/apartments/${id}`),
};

// Car API calls
export const carApi = {
  getAll: () => api.get('/cars'),
  create: (car: any) => api.post('/cars', car),
};

// Food API calls
export const foodApi = {
  getAll: () => api.get('/foods'),
  create: (food: any) => api.post('/foods', food),
};

// P2P API calls
export const p2pApi = {
  getAll: () => api.get('/p2p'),
  getById: (id: string) => api.get(`/p2p/${id}`),
  create: (item: any) => api.post('/p2p', item),
  update: (id: string, item: any) => api.put(`/p2p/${id}`, item),
  delete: (id: string) => api.delete(`/p2p/${id}`),
};

// Contact API calls
export const contactApi = {
  create: (message: any) => api.post('/contact', message),
};