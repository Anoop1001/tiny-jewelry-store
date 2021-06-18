import { TestBed } from '@angular/core/testing';

import { JewelleryStoreApiService } from './jewellery-store-api.service';

describe('JewelleryStoreApiService', () => {
  let service: JewelleryStoreApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(JewelleryStoreApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
