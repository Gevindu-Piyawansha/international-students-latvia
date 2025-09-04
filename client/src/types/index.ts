export interface Apartment {
  id: string;
  title: string;
  description: string;
  price: number;
  location: string;
  images: string[];
  contactInfo: string;
  userId: string;
  createdAt: string;
  available: boolean;
}

export interface Car {
  id: string;
  make: string;
  model: string;
  year: number;
  price: number;
  description: string;
  images: string[];
  contactInfo: string;
  userId: string;
  createdAt: string;
  available: boolean;
}

export interface Food {
  id: string;
  name: string;
  description: string;
  price: number;
  category: string;
  images: string[];
  contactInfo: string;
  userId: string;
  available: boolean;
  createdAt: string;
}

export interface P2PItem {
  id: string;
  title: string;
  description: string;
  price: number;
  category: string;
  condition: 'new' | 'used' | 'good';
  images: string[];
  contactInfo: string;
  userId: string;
  available: boolean;
  createdAt: string;
}

export interface ContactMessage {
  id: string;
  name: string;
  email: string;
  subject: string;
  message: string;
  createdAt: string;
}

// API DTOs
export interface CreateApartmentDto {
  title: string;
  description: string;
  price: number;
  location: string;
  images: string[];
  contactInfo: string;
}

export interface CreateCarDto {
  make: string;
  model: string;
  year: number;
  price: number;
  description: string;
  images: string[];
  contactInfo: string;
}

export interface CreateFoodDto {
  name: string;
  description: string;
  price: number;
  category: string;
  images: string[];
  contactInfo: string;
}

export interface CreateP2PItemDto {
  title: string;
  description: string;
  price: number;
  category: string;
  condition: string;
  images: string[];
  contactInfo: string;
}

export interface CreateContactMessageDto {
  name: string;
  email: string;
  subject: string;
  message: string;
}