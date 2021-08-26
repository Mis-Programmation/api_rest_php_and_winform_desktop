<?php

declare(strict_types=1);

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\JsonResponse;
use Symfony\Component\Routing\Annotation\Route;

class IndexController extends AbstractController
{


    #[Route('/index', name: 'soko')]
    public function index(): JsonResponse
    {
        return $this->json([
            'name' => 'soko'
        ]);
    }

}