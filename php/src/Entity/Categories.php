<?php

declare(strict_types=1);

namespace App\Entity;

use ApiPlatform\Core\Annotation\ApiResource;
use App\Repository\CategoriesRepository;
use Doctrine\Common\Collections\ArrayCollection;
use Doctrine\Common\Collections\Collection;
use Doctrine\ORM\Mapping as ORM;
use Doctrine\ORM\Mapping\Column;
use Doctrine\ORM\Mapping\Entity;
use Doctrine\ORM\Mapping\Table;
use Symfony\Component\Validator\Constraints as Assert;
use Symfony\Component\Serializer\Annotation\Groups;

#[
    ApiResource(
        collectionOperations: [
            "GET",
            "POST"
        ],
        itemOperations: [
            'GET',
            "PUT",
            "DELETE"
        ]
    )
]

/**
 * @Table()
 * @Entity(repositoryClass=CategoriesRepository::class)
 */
class Categories
{
    use IdTrait;
    use TimeTrait;


    #[Assert\NotBlank]
    #[ Groups(["read:categories"]) ]
    /**
     * @Column(type="string",length=80,nullable=false)
     */
    private ?string $libelle = null;


    /**
     * @var Collection
     * @ORM\OneToMany(targetEntity="App\Entity\Product",mappedBy="category",cascade={"remove"})
     */
    private Collection $products;


    public function __construct()
    {
        $this->products = new ArrayCollection();
        $this->createdAt = new \DateTimeImmutable();
    }

    /**
     * @return string|null
     */
    public function getLibelle(): ?string
    {
        return $this->libelle;
    }

    /**
     * @param string|null $libelle
     * @return Categories
     */
    public function setLibelle(?string $libelle): Categories
    {
        $this->libelle = $libelle;
        return $this;
    }

    /**
     * @return ArrayCollection|Collection
     */
    public function getProducts(): ArrayCollection|Collection
    {
        return $this->products;
    }







}